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
            set.Bind(TipLabel).To(vm => vm.E85EthenolContent);
            set.Bind(SubTotalTextField).To(vm => vm.E85EthenolContent);
            set.Bind(GenerositySlider).To(vm => vm.E85EthenolContent);
            set.Apply();

            // this is optional. What this code does is to close the keyboard whenever you 
            // tap on the screen, outside the bounds of the TextField
            View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
            {
                this.SubTotalTextField.ResignFirstResponder();
            }));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

