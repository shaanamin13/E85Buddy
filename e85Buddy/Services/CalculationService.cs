using System;
namespace E85Buddy.Services
{
    public class CalculationService : ICalculationService
    {
        public int EthCalc(double tankCapacity, double tankPercentage, double e85EthenolContent, double gasEthenolContent, double targetEthenolMix, double currentEthenolMix)
        {
            double tankAmount = tankCapacity * (tankPercentage / 100);
            double toFill = (tankCapacity - tankAmount);

                
            int ethenolPercentageNeeded = (int)(((targetEthenolMix) - ((tankPercentage / 100) * tankAmount)) / (toFill/tankCapacity));

           // double gasNeeded, ethNeeded;
           

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
            solution(e85EthenolContent, gasEthenolContent, ethenolPercentageNeeded * toFill);
            return ethenolPercentageNeeded;

        }

      
  

        public double GasCalc(double tankCapacity, double tankPercentage, double e85EthenolContent, double gasEthenolContent, double targetEthenolMix, double currentEthenolMix)
        {
            throw new NotImplementedException();
        }


        static void solution(double a, double b, double n)
        {

            Console.WriteLine("e85% = " + a +
                                  ", gas% = " + b);

            // traverse for all possible values 
            for (int i = 0; i * a <= n; i++)
            {
               
                // check if it is satisfying the 
                // equation 
                if ((n - (i * a)) % b > -5 && (n - (i * a)) % b < 5)
                {
                    Console.WriteLine("x = " + i +
                                    ", y = " +
                            (n - (i * a)) / b);

                    return;
                }
            }

            Console.Write("No solution");
        }
    }
}
