using ESI.NET.Models.SSO;
using MllMongoBackend.Interfaces;

namespace MllMongoBackend.Models;

public class Character : Entity
{
    public string Id { get; set; }
    public SsoToken Token { get; set; }
    public bool Tracking { get; set; }
}

