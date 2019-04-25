// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace E85Buddy.iOS.Views
{
    [Register ("E85CalcVIew")]
    partial class E85CalcVIew
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CurrentEthenol { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider E85Content { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField E85ECText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider GasE85Content { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField GasECText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TankCapacityField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider TankPercentage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TargetEthenol { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TPtext { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CurrentEthenol != null) {
                CurrentEthenol.Dispose ();
                CurrentEthenol = null;
            }

            if (E85Content != null) {
                E85Content.Dispose ();
                E85Content = null;
            }

            if (E85ECText != null) {
                E85ECText.Dispose ();
                E85ECText = null;
            }

            if (GasE85Content != null) {
                GasE85Content.Dispose ();
                GasE85Content = null;
            }

            if (GasECText != null) {
                GasECText.Dispose ();
                GasECText = null;
            }

            if (TankCapacityField != null) {
                TankCapacityField.Dispose ();
                TankCapacityField = null;
            }

            if (TankPercentage != null) {
                TankPercentage.Dispose ();
                TankPercentage = null;
            }

            if (TargetEthenol != null) {
                TargetEthenol.Dispose ();
                TargetEthenol = null;
            }

            if (TPtext != null) {
                TPtext.Dispose ();
                TPtext = null;
            }
        }
    }
}