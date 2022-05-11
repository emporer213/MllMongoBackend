using MllMongoBackend.Interfaces;

namespace MllMongoBackend.Models;

public class Route : Entity
{
    public string Origin { get; set; }
    public string Destination { get; set; }
    public double MinReward { get; set; }
    public double MaxVolume { get; set; }
    public double MaxCollateral { get; set; }
    public IPrice Price { get; set; }
    public bool IsRush { get; set; }
}

public interface IPrice
{
   double Price { get; set; }
   double RushShippingCharge { get; set; }
   double CollateralMultiplier { get; set; }
   double CalculateReward(double collateral, bool isRush, double volume = 0);
}
