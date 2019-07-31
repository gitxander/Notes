using System;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace notes
{
    public class EntryTableViewSource : UITableViewSource
    {

        List<Entry> entries;
        UIViewController _parent;

        public EntryTableViewSource(List<Entry> entries, UIViewController parent)
        {
            this.entries = entries;
            _parent = parent;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "");
            cell.TextLabel.Text = entries[indexPath.Row].body;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return entries.Count;
        }
        
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            UIStoryboard storyboard = UIStoryboard.FromName("entryBodyStoryboard", null);

            //Instantiate the ViewController you want to navigate to.
            //Make sure you have set the Storyboard ID for this ViewController in your storyboard file.
            //Put this Storyboard ID in place of the TargetViewControllerName in below line. 
            UIViewController vcInstance = (UIViewController)storyboard.InstantiateViewController("EntryBodyViewController");


            //Get the Instance of the TopViewController (CurrentViewController) or the NavigationViewController to push the TargetViewController onto the stack. 
            //NavigationController is an Instance of the NavigationViewController
            _parent.NavigationController.PushViewController(vcInstance, true);
        }
    }
}
