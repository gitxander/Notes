using Foundation;
using System;
using UIKit;

namespace notes
{
    public partial class AnimalViewController : UIViewController
    {

        public Animal animal;

        public AnimalViewController (IntPtr handle) : base (handle)
        {
            animal = new Animal();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            dogButton.TouchUpInside += (s, e) =>
            {
                animal.Name = "dog";
            };

            catButton.TouchUpInside += (s, e) =>
            {
                animal.Name = "cat";
            };

            hamsterButton.TouchUpInside += (s, e) =>
            {
                animal.Name = "hamster";
            };

            koalaButton.TouchUpInside += (s, e) =>
            {
                animal.Name = "koala";
            };
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var animalVC = segue.DestinationViewController as AnimalDetailViewController;
            if (animalVC != null)
                animalVC.animal = animal;
        }
    }
}