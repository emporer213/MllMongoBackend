namespace MllMongoBackend.Models;

public class Service
{
    public string Name { get; set; }
    public double HighsecPrice { get; set; }
    public double LowsecPrice { get; set; }
    public double NullsecPrice { get; set; }
    public double MaxAllowedVolume { get; set; }
    public double MaxCollateral { get; set; }
    public struct OperatingAreas
    {
        public bool Highsec { get; set; }
        public bool Lowsec { get; set; }
        public bool Nullsec { get; set; }
    }
    public bool isRush { get; set; }
    public double RushMultiplier { get; set; }
    public double MinRushPrice { get; set; }
}
