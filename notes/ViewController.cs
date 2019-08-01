using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace notes
{
    public partial class ViewController : UIViewController
    {

        public List<Entry> allEntry { get; set; }

        public ViewController(IntPtr handle) : base(handle)
        {
            allEntry = new List<Entry>();
        }

        private int a = 125;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            addButton.TouchUpInside += (s, e) =>
            {
                //helloLabel.Text = "hi there!";

                //UILabel label = new UILabel()
                //{
                //    // cgrect(edge, top, width, height
                //    Frame = new CoreGraphics.CGRect(20, a, View.Bounds.Width - 40, 40),
                //    Text = textField.Text,
                //    Font = UIFont.FromName("Papyrus", 20f),
                //    TextColor = UIColor.Magenta,
                //    TextAlignment = UITextAlignment.Center
                //};

                //a += 50;
                Entry entry = new Entry(textField.Text);

                allEntry.Add(entry);


                //View.AddSubview(label);

                entryTable.Source = new EntryTableViewSource(allEntry, this);
                entryTable.ReloadData();
            };

        }

        //public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        //{
        //    base.PrepareForSegue(segue, sender);

        //    var allEntryController = segue.DestinationViewController as ShowAllEntryController;
        //    if (allEntryController != null)
        //        allEntryController.allEntry = allEntry;
        //}

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}