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

            if(currentEthenolMix == 0)
                ethenolPercentageNeeded = (((tankCapacity * targetEthenolMix) - (1 * tankAmount)) / (toFill));

          
            double e85Gal = e85ToAdd(e85EthenolContent, ethenolPercentageNeeded * toFill);
            //solution(e85EthenolContent/100, gasEthenolContent/100, (targetEthenolMix/100) * toFill);
            Console.WriteLine("ToFill: " + toFill);
            return e85Gal;

        }

     

        private double e85ToAdd(double e85EthenolContent, double target)
        {
            return target / e85EthenolContent;
        }

       
        static void solution(double a, double b, double n)
        {

            Console.WriteLine("e85% = " + a +
                                  ", gas% = " + b);

            // traverse for all possible values 
            for (double i = 0; i <= n; i += .1)
            {
                for(double j = 0; j < n; j += .1)
                {

                    if (Math.Abs((a * i) + (b * j) - n) < 1)
                    {
                        Console.WriteLine("e85ToAdd = " + i +
                                    ", GasToAdd = " +
                            j );

                      

                        return;
                    }
                }
             
            }

            Console.Write("No solution");
        }

        public double GasCalc(double ethenolToAdd)
        {
            return toFill - ethenolToAdd;
        }
    }
}
