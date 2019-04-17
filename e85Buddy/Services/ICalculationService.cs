using System;
namespace E85Buddy.Services
{
    public interface ICalculationService
    { 
        double GasCalc(double tankCapacity, double tankPercentage, double e85EthenolContent, double gasEthenolContent, double targetEthenolMix, double currentEthenolMix);
        double EthCalc(double tankCapacity, double tankPercentage, double e85EthenolContent, double gasEthenolContent, int targetEthenolMix, int currentEthenolMix);
    }
}
