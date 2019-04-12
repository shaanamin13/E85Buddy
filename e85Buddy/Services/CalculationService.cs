using System;
namespace E85Buddy.Services
{
    public class CalculationService : ICalculationService
    {
        public double EthCalc(double tankCapacity, double tankPercentage, double e85EthenolContent, double gasEthenolContent, double targetEthenolMix, double currentEthenolMix)
        {
            double tankAmount = tankCapacity * (tankPercentage / 100);
            double toFill = tankCapacity - tankAmount;

            double ethenolPercentageNeeded = toFill / ((tankCapacity / targetEthenolMix) - (tankAmount / currentEthenolMix));
            return ethenolPercentageNeeded;
        }

        public double GasCalc(double tankCapacity, double tankPercentage, double e85EthenolContent, double gasEthenolContent, double targetEthenolMix, double currentEthenolMix)
        {
            throw new NotImplementedException();
        }

     

    }
}
