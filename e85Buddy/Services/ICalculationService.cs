using System;
namespace E85Buddy.Services
{
    public interface ICalculationService
    { 
        double EthCalc(double tankCapacity, double tankPercentage, double e85EthenolContent, double gasEthenolContent, int targetEthenolMix, int currentEthenolMix);
        double GasCalc(double ethenolToAdd);
    }
}
