using MllMongoBackend.Interfaces;

namespace MllMongoBackend.Models;

public class SolarSystem : Entity
{
    public string Name { get; set; }
    
    public string Id { get; set; }
    
    public string Security { get; set; }
}
