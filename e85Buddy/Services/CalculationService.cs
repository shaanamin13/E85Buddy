using System;
namespace E85Buddy.Services
{
    public class CalculationService : ICalculationService
    {

        private double toFill;
        public double EthCalc(double tankCapacity, double tankPercentage, double e85EthenolContent, double gasEthenolContent, int targetEthenolMix, int currentEthenolMix)
        {
            double tankAmount = tankCapacity * (tankPercentage / 100);
            toFill = (tankCapacity - tankAmount);

            double ethenolPercentageNeeded = (((tankCapacity * targetEthenolMix) - (currentEthenolMix * tankAmount) )/ (toFill));
          
            double e85Gal = e85ToAdd(e85EthenolContent, gasEthenolContent, ethenolPercentageNeeded * toFill);

            return e85Gal;

        }

     

        private double e85ToAdd(double e85EthenolContent, double gasEthenolContent, double target)
        {
            return (target / e85EthenolContent);
        }

       
  

        public double GasCalc(double ethenolToAdd)
        {
            return toFill - ethenolToAdd;
        }
    }
}
