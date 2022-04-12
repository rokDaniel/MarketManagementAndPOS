using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Logic.Business_Layer
{
    public class Statistics
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string TotalIncome { get; set; }
        public string TotalItems { get; set; }
        public string TotalTransactions { get; set; }
        public string TotalItemsSold { get; set; }
    }
}
