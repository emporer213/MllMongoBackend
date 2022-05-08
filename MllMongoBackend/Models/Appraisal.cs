using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MllMongoBackend.Models;

public class Appraisal
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    
    [BsonElement("from")]
    public string Origin { get; set; }
    
    [BsonElement("to")]
    public string Destination { get; set; }
    
    [BsonElement("service")]
    public ServiceType ServiceType { get; set; }
    
    public double Volume { get; set; }
    
    public double Reward { get; set; }
    
    public double Collateral { get; set; }
    
    [BsonElement("jumps")]
    public int NumberOfJumps { get; set; }
}

public enum ServiceType
{
    JumpFreighter,
    Freighter,
    DST
}
