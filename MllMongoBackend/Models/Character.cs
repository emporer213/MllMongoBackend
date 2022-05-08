using ESI.NET.Models.SSO;

namespace MllMongoBackend.Models;

public class Character
{
    public string Id { get; set; }
    public SsoToken Token { get; set; }
    public bool Tracking { get; set; }
}

