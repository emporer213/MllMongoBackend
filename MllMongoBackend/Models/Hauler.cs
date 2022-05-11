using MllMongoBackend.Interfaces;

namespace MllMongoBackend.Models;

public class Hauler : Entity
{
    public string CharacterName { get; set; }
    //TODO these should be secure
    public string Username { get; set; }
    public string Password { get; set; }
}
