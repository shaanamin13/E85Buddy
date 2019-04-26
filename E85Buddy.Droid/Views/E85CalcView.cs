
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using E85Buddy.ViewModels;
using Microcharts;
using Microcharts.Droid;
using MvvmCross.Platforms.Android.Views;
using SkiaSharp;

namespace E85Buddy.Droid.Views
{
    [Activity(Label = "E85CalcView", MainLauncher = true)]
    public class E85CalcView : MvxActivity<E85CalcViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.E85CalcView);


            var entries = new[]
           {
                new Entry(4)
                 {
                    Label = "E85",
                    ValueLabel = "4",
                    Color = SKColor.Parse("#266489")
                    },
                    new Entry(4)
                    {
                    Label = "Gas",
                    ValueLabel = "4 Gal",
                    Color = SKColor.Parse("#68B9C0")
                    },
                    new Entry(10)
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
            var chartView = FindViewById<ChartView>(Resource.Id.chartView);
            chartView.Chart = chart;
        }
    }
}
