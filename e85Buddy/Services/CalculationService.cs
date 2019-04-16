using System;
namespace E85Buddy.Services
{
    public class CalculationService : ICalculationService
    {
        public double EthCalc(double tankCapacity, double tankPercentage, double e85EthenolContent, double gasEthenolContent, double targetEthenolMix, double currentEthenolMix)
        {
            double tankAmount = tankCapacity * (tankPercentage / 100);
            double toFill = (tankCapacity - tankAmount)/tankCapacity;

                
            double ethenolPercentageNeeded = ((targetEthenolMix) - ((tankPercentage / 100) * tankAmount)) / (toFill);
            return ethenolPercentageNeeded;

            /*
             * 16 capacity
             * 60% tank percentage
             * 30% target ethenol
             * 10% current ethenol
             * 
             * 16 * .6 = 9.6   - tank amount
             * 16 - 9.6 = 6.4 - toFill
             * tank target = 16/30
             * tank current = 3 
             *             
            */
        }

      
  

        public double GasCalc(double tankCapacity, double tankPercentage, double e85EthenolContent, double gasEthenolContent, double targetEthenolMix, double currentEthenolMix)
        {
            throw new NotImplementedException();
        }
    }
}
