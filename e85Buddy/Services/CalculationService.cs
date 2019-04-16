using System;
namespace E85Buddy.Services
{
    public class CalculationService : ICalculationService
    {
        public double EthCalc(double tankCapacity, double tankPercentage, double e85EthenolContent, double gasEthenolContent, double targetEthenolMix, double currentEthenolMix)
        {
            double tankAmount = tankCapacity * (tankPercentage / 100);
            double toFill = tankCapacity - tankAmount;
            double tankTarget = tankCapacity / targetEthenolMix;
            double tankCurrent = tankAmount / currentEthenolMix;
            double ethenolPercentageNeeded = 1 / ((tankCurrent - tankTarget)/toFill);
            return ethenolPercentageNeeded;

            /*
             * 16 capacity
             * 60% tank percentage
             * 30% target ethenol
             * 10% current ethenol            
            */
        }

      
  

        public double GasCalc(double tankCapacity, double tankPercentage, double e85EthenolContent, double gasEthenolContent, double targetEthenolMix, double currentEthenolMix)
        {
            throw new NotImplementedException();
        }
    }
}
