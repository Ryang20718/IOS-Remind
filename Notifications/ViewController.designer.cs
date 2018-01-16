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

namespace Notifications
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LockerCombinationTxtView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LockerNumberTxtView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (button != null) {
                button.Dispose ();
                button = null;
            }

            if (lNum != null) {
                lNum.Dispose ();
                lNum = null;
            }

            if (LockerCombinationTxtView != null) {
                LockerCombinationTxtView.Dispose ();
                LockerCombinationTxtView = null;
            }

            if (LockerNumberTxtView != null) {
                LockerNumberTxtView.Dispose ();
                LockerNumberTxtView = null;
            }
        }
    }
}