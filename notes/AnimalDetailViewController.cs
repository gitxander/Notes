using Foundation;
using System;
using UIKit;

namespace notes
{
    public partial class AnimalDetailViewController : UIViewController
    {
        public Animal animal;

        public AnimalDetailViewController (IntPtr handle) : base (handle)
        {
            animal = new Animal();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            UILabel label = new UILabel()
            {
                // cgrect(edge, top, width, height
                Frame = new CoreGraphics.CGRect(20, 145, View.Bounds.Width - 40, 40),
                Text = animal.Name,
                Font = UIFont.FromName("Papyrus", 20f),
                TextColor = UIColor.Magenta,
                TextAlignment = UITextAlignment.Center
            };

            View.AddSubview(label);

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

           
        }
    }
}