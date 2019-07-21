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

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton393_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }

        partial void UIButton395_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }

        partial void UIButton401_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }
    }
}