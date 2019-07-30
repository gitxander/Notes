using System;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace notes
{
    public class EntryTableViewSource : UITableViewSource
    {

        List<Entry> entries;

        public EntryTableViewSource(List<Entry> entries)
        {
            this.entries = entries;
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
