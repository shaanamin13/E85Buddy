using System;
using E85Buddy;
using E85Buddy.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace E85Buddy.iOS.Views
{
    public partial class E85CalcVIew : MvxViewController<E85CalcViewModel>
    {
        public E85CalcVIew() : base("E85CalcVIew", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            var set = this.CreateBindingSet<E85CalcVIew, E85CalcViewModel>();
            set.Bind(TankCapacityField).To(vm => vm.TankCapacity);
            set.Bind(TankPercentage).To(vm => vm.TankPercentage);
            set.Bind(E85Content).To(vm => vm.E85EthenolContent);

            set.Bind(GasE85Content).To(vm => vm.GasEthenolContent);
            set.Bind(TargetEthenol).To(vm => vm.TargetEthenolMix);
            set.Bind(CurrentEthenol).To(vm => vm.CurrentEthenolMix);
            set.Bind(EthenolNeeded).To(vm => vm.EthenolToAdd);
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

