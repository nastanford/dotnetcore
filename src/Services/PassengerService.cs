using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace Services
{
    public class PassengerService : IPassengerService
    {
        private readonly IAmazonDynamoDB _db;

        public PassengerService(IAmazonDynamoDB db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Passenger>> GetPassengers()
        {
            return await _db.QueryAsync(new QueryRequest()
            {
                TableName = "dotnetcore",
                KeyConditionExpression = "Id = :v_Id",
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                {
                    {":v_Id", new AttributeValue {S = "12345"}}
                }
            })
                .ContinueWith(
                    task =>
                        task.Result.Items.Select(
                            row => new Passenger {Name = row["FirstName"].S, Surname = row["LastName"].S}));
        }
    }
}
