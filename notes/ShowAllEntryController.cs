using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace notes
{
    public partial class ShowAllEntryController : UITableViewController
    {

        public List<Entry> allEntry { get; set; }

        static NSString entryCellId = new NSString("entryCellId");

        public ShowAllEntryController (IntPtr handle) : base (handle)
        {
            TableView.RegisterClassForCellReuse(typeof(UITableViewCell), entryCellId);
            TableView.Source = new AllEntryDataSource(this);
            allEntry = new List<Entry>();
        }

        class AllEntryDataSource : UITableViewSource
        {
            ShowAllEntryController controller;

            public AllEntryDataSource(ShowAllEntryController controller)
            {
                this.controller = controller;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return controller.allEntry.Count;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell(ShowAllEntryController.entryCellId);

                int row = indexPath.Row;
                cell.TextLabel.Text = controller.allEntry[row].body;
                return cell;
            }
        }
    }
}