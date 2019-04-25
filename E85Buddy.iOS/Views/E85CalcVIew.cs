using System;
using E85Buddy;
using E85Buddy.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using UIKit;
using Microcharts;
using SkiaSharp;
using Microcharts.iOS;
using CoreGraphics;

namespace E85Buddy.iOS.Views
{
    public partial class E85CalcVIew : MvxViewController<E85CalcViewModel>
    {
        public override bool PrefersStatusBarHidden()
        {
            return true;
        }
        public E85CalcVIew() : base("E85CalcVIew", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
           
            var entries = new[]
           {
                new Entry(TankPercentage.Value)
                 {
                    Label = "E85",
                    ValueLabel = TankPercentage.Value.ToString(),
                    Color = SKColor.Parse("#266489")
                    },
                    new Entry(400)
                    {
                    Label = "Gas",
                    ValueLabel = "4 Gal",
                    Color = SKColor.Parse("#68B9C0")
                    },
                    new Entry(100)
                    {
                    Label = "Tank",
                    ValueLabel = "8.6",
                    Color = SKColor.Parse("#90D585")
                    }
            };

            var chart = new DonutChart() { Entries = entries };
            chart.HoleRadius = .5f;
            chart.LabelTextSize = 50f;
            chart.BackgroundColor = SKColor.Parse("#303030");
            var chartView = new ChartView
            {
                Frame = new CGRect(0, this.View.Bounds.Height - 200, this.View.Bounds.Width, 200),
                AutoresizingMask = UIViewAutoresizing.FlexibleWidth,
                Chart = chart
            };
            this.View.AddSubview(chartView);






            var set = this.CreateBindingSet<E85CalcVIew, E85CalcViewModel>();
            set.Bind(TankCapacityField).To(vm => vm.TankCapacity);
            set.Bind(TankPercentage).To(vm => vm.TankPercentage);
            set.Bind(E85Content).To(vm => vm.E85EthenolContent);

            set.Bind(GasE85Content).To(vm => vm.GasEthenolContent);
            set.Bind(TargetEthenol).To(vm => vm.TargetEthenolMix);
            set.Bind(CurrentEthenol).To(vm => vm.CurrentEthenolMix);
            //set.Bind(EthenolNeeded).To(vm => vm.EthenolToAdd);
            //set.Bind(GasNeeded).To(vm => vm.GasToAdd);
            set.Bind(chartView).For(vm => vm.Chart).To(vm => vm.DonutChart);

            //Corresponding Text
            set.Bind(TPtext).To(vm => vm.TankPercentage);
            set.Bind(E85ECText).To(vm => vm.E85EthenolContent);
            set.Bind(GasECText).To(vm => vm.GasEthenolContent);
         
            set.Apply();
            // this is optional. What this code does is to close the keyboard whenever you 
            // tap on the screen, outside the bounds of the TextField
            View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
            {
                this.TankCapacityField.ResignFirstResponder();
            }));


        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    
    }
}

