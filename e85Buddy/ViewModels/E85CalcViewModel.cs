using System;
using System.Threading.Tasks;
using E85Buddy.Services;
using MvvmCross.ViewModels;
using Microcharts;
using SkiaSharp;

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
            _e85EthenolContent = 85;
            _gasEthenolContent = 0;
            _targetEthenolMix = 30;
            _currentEthenolMix = 0;

            var tank = (float)((float)(TankPercentage/100) * _tankCapacity);
            var entries = new[]
            {
                 new Entry((float)EthenolToAdd)
                    {
                    Label = "E85",
                    ValueLabel = EthenolToAdd.ToString("0.00"),
                    Color = SKColor.Parse("#E6FF75")
                    },
                    new Entry((float)GasToAdd)
                    {
                    Label = "Gas",
                    ValueLabel = GasToAdd.ToString("0.00"),
                    Color = SKColor.Parse("#5FE8AA")
                    },new Entry(tank)
                    {
                    Label = "Tank",
                    ValueLabel = tank.ToString("0.00"),
                    Color = SKColor.Parse("#6593FF")
                    },
            };

            _donutChart = new DonutChart() { Entries = entries };
            _donutChart.HoleRadius = .5f;
            _donutChart.LabelTextSize = 50f;
            _donutChart.BackgroundColor = SKColor.Parse("#303030");
            //Recalculate();
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

        private int _tankPercentage;
        public int TankPercentage
        {
            get => _tankPercentage;
            set
            {
                _tankPercentage = value;
                RaisePropertyChanged(() => TankPercentage);
                Recalculate();
            }

        }

        private int _e85EthenolContent;
        public int E85EthenolContent
        {
            get => _e85EthenolContent;
            set
            {
                _e85EthenolContent = value;
                RaisePropertyChanged(() => E85EthenolContent);
                Recalculate();
            }

        }


        private int _gasEthenolContent;
        public int GasEthenolContent
        {
            get => _gasEthenolContent;
            set
            {
                _gasEthenolContent = value;
                RaisePropertyChanged(() => GasEthenolContent);
                Recalculate();
            }

        }

        private int _targetEthenolMix;
        public int TargetEthenolMix
        {
            get => _targetEthenolMix;
            set
            {
                _targetEthenolMix = value;
                RaisePropertyChanged(() => TargetEthenolMix);
                Recalculate();
            }

        }

        private int _currentEthenolMix;
        public int CurrentEthenolMix
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
            }
        }

        private double _ethenolToAdd;
        public double EthenolToAdd
        {
            get => _ethenolToAdd;
            set
            {
                _ethenolToAdd = value;
                RaisePropertyChanged(() => 


                EthenolToAdd);
            }
        }

        private DonutChart _donutChart;
        public DonutChart DonutChart
        {
            get => _donutChart;
            set
            {
                _donutChart = value;


               
                RaisePropertyChanged(() =>


                 DonutChart);
            }
        }

        //public Chart DonutChart = new DonutChart()
        //{
        //    Entries = new[] {

        //        new Entry(200)
        //         {
        //            Label = "E85",
        //            ValueLabel = "4.88",
        //            Color = SKColor.Parse("#266489")
        //            },
        //            new Entry(400)
        //            {
        //            Label = "Gas",
        //            ValueLabel = "4 Gal",
        //            Color = SKColor.Parse("#68B9C0")
        //            },
        //            new Entry(100)
        //            {
        //            Label = "Tank",
        //            ValueLabel = "8.6",
        //            Color = SKColor.Parse("#90D585")
        //            }
        //    }

        //};


         //entries = new[]
         //{
               
            //};
      


        private void Recalculate()
        {
           
           
            EthenolToAdd = _calculationService.EthCalc(_tankCapacity, _tankPercentage, _e85EthenolContent, _gasEthenolContent, _targetEthenolMix, _currentEthenolMix);
            GasToAdd = _calculationService.GasCalc(EthenolToAdd);
            float tank = (float)(((float)_tankPercentage / 100) * _tankCapacity);
            var entries = new[]
           {

                    new Entry((float)EthenolToAdd)
                    {
                    Label = "E85",
                    ValueLabel = EthenolToAdd.ToString("0.00"),
                    Color = SKColor.Parse("#E6FF75")
                    },
                    new Entry((float)GasToAdd)
                    {
                    Label = "Gas",
                    ValueLabel = GasToAdd.ToString("0.00"),
                    Color = SKColor.Parse("#5FE8AA")
                    },new Entry(tank)
                    {
                    Label = "Tank",
                    ValueLabel = tank.ToString("0.00"),
                    Color = SKColor.Parse("#6593FF")
                    },
            };

            DonutChart = new DonutChart() { Entries = entries };
            DonutChart.HoleRadius = .5f;
            DonutChart.LabelTextSize = 50f;
            DonutChart.BackgroundColor = SKColor.Parse("#303030");
        }
    }
}
