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
        
    }
}
