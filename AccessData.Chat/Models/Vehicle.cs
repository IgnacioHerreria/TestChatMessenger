using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AccessData.Chat.Models
{
    public class Vehicle
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Vin")]
        public string Vin { get; set; }

        public decimal Price { get; set; }
        public int Km { get; set; }
    }
}
