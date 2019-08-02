using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace notes
{
    public partial class AnimalDetailViewController : UIViewController
    {
        public Animal animal;
        public List<Entry> allEntry { get; set; }

        public AnimalDetailViewController (IntPtr handle) : base (handle)
        {
            animal = new Animal();
            allEntry = new List<Entry>();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            nameLabel.Text = animal.Name;
            descriptionField.Text = animal.Description;

            animalImage.Image = UIImage.FromBundle(animal.Name.ToLower() + ".jpg");

            addDescButton.TouchUpInside += (s, e) =>
            {
                descriptionTextField.ResignFirstResponder();

                Entry entry = new Entry(descriptionTextField.Text);
                allEntry.Add(entry);

                desciptionTableView.Source = new EntryTableViewSource(allEntry, this);
                desciptionTableView.ReloadData();
                descriptionTextField.Text = "";
            };

        }
    }
}