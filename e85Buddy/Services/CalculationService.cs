using System;
namespace E85Buddy.Services
{
    public class CalculationService : ICalculationService
    {
        public double TipAmount(double subTotal, int generosity) {
            return subTotal * (((double)generosity) / 100.0);
          }


    }
}
