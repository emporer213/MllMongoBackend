using ESI.NET.Enumerations;

namespace MllMongoBackend.Models;

public class Contract
{
    public string Id { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime CompletionDate { get; set; }
    public ContractType Type { get; set; }
    public ContractStatus Status { get; set; }
    public string IssuerId { get; set; }
    public string IssuerName { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public double Volume { get; set; }
    public double Reward { get; set; }
    public double Collateral { get; set; }
    public double Description { get; set; }
    public ServiceType ServiceType { get; set; }
    public Appraisal Appraisal { get; set; }
    public bool IsMailed { get; set; }
    public bool DeliveryAcknowledged { get; set; }
    public ValidationStatus ValidationStatus { get; set; }
    public DiscordNotification DiscordNotification { get; set; }
    
}

public class DiscordNotification
{
    public bool Sent { get; set; }
    public DateTime Time { get; set; } 
    public bool ReminderSent { get; set; }
}

public class ValidationStatus
{
    public bool RewardError { get; set; }
    public bool CollateralError { get; set; }
}

public enum ContractStatus
{
    Outstanding,
    InProgress,
    Completed,
    Rejected
}
