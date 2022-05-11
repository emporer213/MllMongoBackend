using MongoDB.Bson;

namespace MllMongoBackend.Interfaces;

public abstract class Entity
{
    public ObjectId Id { get; set; }
}
