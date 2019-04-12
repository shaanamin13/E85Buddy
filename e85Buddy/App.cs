using System;
using MvvmCross;
using MvvmCross.ViewModels;
using E85Buddy.Services;
using E85Buddy.ViewModels;

namespace E85Buddy
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<E85CalcViewModel>();
        }
    }
}
