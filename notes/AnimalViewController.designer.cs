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

namespace notes
{
    [Register ("AnimalViewController")]
    partial class AnimalViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton catButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton dogButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton hamsterButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton koalaButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (catButton != null) {
                catButton.Dispose ();
                catButton = null;
            }

            if (dogButton != null) {
                dogButton.Dispose ();
                dogButton = null;
            }

            if (hamsterButton != null) {
                hamsterButton.Dispose ();
                hamsterButton = null;
            }

            if (koalaButton != null) {
                koalaButton.Dispose ();
                koalaButton = null;
            }
        }
    }
}