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
    [Register ("AnimalDetailViewController")]
    partial class AnimalDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView animalImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView descriptionField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel nameLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (animalImage != null) {
                animalImage.Dispose ();
                animalImage = null;
            }

            if (descriptionField != null) {
                descriptionField.Dispose ();
                descriptionField = null;
            }

            if (nameLabel != null) {
                nameLabel.Dispose ();
                nameLabel = null;
            }
        }
    }
}