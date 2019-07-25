using Foundation;
using System;
using UIKit;

namespace notes
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        private int a = 125;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            addButton.TouchUpInside += (s, e) =>
            {
                helloLabel.Text = "hi there!";

                UILabel label = new UILabel()
                {
                    Frame = new CoreGraphics.CGRect(20, a, View.Bounds.Width - 40, 40),
                    Text = textField.Text,
                    Font = UIFont.FromName("Papyrus", 20f),
                    TextColor = UIColor.Magenta,
                    TextAlignment = UITextAlignment.Center
                };

                a += 50;

              
                View.AddSubview(label);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}