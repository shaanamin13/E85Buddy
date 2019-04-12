using System;
using System.Threading.Tasks;
using E85Buddy.Services;
using MvvmCross.ViewModels;

namespace E85Buddy.ViewModels
{
    public class E85CalcViewModel : MvxViewModel
    {
        readonly ICalculationService _calculationService;

        public E85CalcViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            _tankCapacity = 16;
            _tankPercentage = 10;
            _e85EthenolContent = 20;
            _gasEthenolContent = 10;
            _targetEthenolMix = 10;
            _currentEthenolMix = 10;



            Recalculate();
        }


        private double _tankCapacity;
        public double TankCapacity
        {
            get => _tankCapacity;
            set
            {
                _tankCapacity = value;
                RaisePropertyChanged(() => TankCapacity);
                Recalculate();
            }

        }

        private double _tankPercentage;
        public double TankPercentage
        {
            get => _tankPercentage;
            set
            {
                _tankPercentage = value;
                RaisePropertyChanged(() => TankPercentage);
                Recalculate();
            }

        }

        private double _e85EthenolContent;
        public double E85EthenolContent
        {
            get => _e85EthenolContent;
            set
            {
                _e85EthenolContent = value;
                RaisePropertyChanged(() => E85EthenolContent);
                Recalculate();
            }

        }


        private double _gasEthenolContent;
        public double GasEthenolContent
        {
            get => _gasEthenolContent;
            set
            {
                _gasEthenolContent = value;
                RaisePropertyChanged(() => GasEthenolContent);
                Recalculate();
            }

        }

        private double _targetEthenolMix;
        public double TargetEthenolMix
        {
            get => _targetEthenolMix;
            set
            {
                _targetEthenolMix = value;
                RaisePropertyChanged(() => TargetEthenolMix);
                Recalculate();
            }

        }

        private double _currentEthenolMix;
        public double CurrentEthenolMix
        {
            get => _currentEthenolMix;
            set
            {
                _currentEthenolMix = value;
                RaisePropertyChanged(() => CurrentEthenolMix);
                Recalculate();
            }

        }


        private double _gasToAdd;
        public double GasToAdd
        {
            get => _gasToAdd;
            set
            {
                _gasToAdd = value;
                RaisePropertyChanged(() => GasToAdd);
                Recalculate();
            }
        }

        private double _ethenolToAdd;
        public double EthenolToAdd
        {
            get => _ethenolToAdd;
            set
            {
                _ethenolToAdd = value;
                RaisePropertyChanged(() => EthenolToAdd);
                Recalculate();
            }
        }




        //private double _subTotal;
        //public double SubTotal
        //{
        //    get => _subTotal;
        //    set
        //    {
        //        _subTotal = value;
        //        RaisePropertyChanged(() => SubTotal);
        //        Recalculate();
        //    }
        //}

        //private int _generosity;
        //public int Generosity
        //{
        //    get => _generosity;
        //    set
        //    {
        //        _generosity = value;
        //        RaisePropertyChanged(() => Generosity);
        //        Recalculate();
        //    }
        //}

        //private double _tip;
        //public double Tip
        //{
        //    get => _tip;
        //    set
        //    {
        //        _tip = value;
        //        RaisePropertyChanged(() => Tip);
        //    }
        //}

        private void Recalculate()
        {
           
            GasToAdd = _calculationService.GasCalc(_tankCapacity,_tankPercentage,_e85EthenolContent,_gasEthenolContent, _targetEthenolMix, _currentEthenolMix);
            EthenolToAdd = _calculationService.EthCalc(_tankCapacity, _tankPercentage, _e85EthenolContent, _gasEthenolContent, _targetEthenolMix, _currentEthenolMix);

        }
    }
}
