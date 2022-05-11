using MllMongoBackend.Interfaces;

namespace MllMongoBackend.Models;

public class Settings : Entity
{
    public bool MailsEnabled { get; set; }
    public bool DiscordEnabled { get; set; }
}
