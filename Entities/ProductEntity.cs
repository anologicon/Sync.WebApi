using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Sync.WebApi.Entities
{
    public class ProductEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public int ProductId { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
        
        public float Price { get; set; }
        
        public int Stock { get; set; }
    }
}