using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace notes
{
    public partial class EntryBodyViewController : UIViewController
    {
        public List<Entry> allEntry { get; set; }

        public EntryBodyViewController(IntPtr handle) : base(handle)
        {
            allEntry = new List<Entry>();

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            UILabel label = new UILabel()
            {
                // cgrect(edge, top, width, height
                Frame = new CoreGraphics.CGRect(20, 145, View.Bounds.Width - 40, 40),
                Text = "hello",
                Font = UIFont.FromName("Papyrus", 20f),
                TextColor = UIColor.Magenta,
                TextAlignment = UITextAlignment.Center
            };

            View.AddSubview(label);
        }
    }
}