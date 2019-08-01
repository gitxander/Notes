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

            nameLabel.Text = animal.Name;
            descriptionField.Text = animal.Description;

            animalImage.Image = UIImage.FromBundle(animal.Name.ToLower() + ".jpg");

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

           
        }
    }
}