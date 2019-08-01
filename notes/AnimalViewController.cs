using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace notes
{
    public partial class AnimalViewController : UIViewController
    {

        public List<Animal> animal;
        public Animal selectedAnimal;

        public AnimalViewController (IntPtr handle) : base (handle)
        {
            animal = new List<Animal>();
            selectedAnimal = new Animal();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            Animal dog = new Animal();
            dog.Name = "Dog";
            dog.Description = "desc";

            animal.Add(dog);

            Animal cat = new Animal();
            cat.Name = "Cat";
            cat.Description = "desc";

            animal.Add(cat);

            Animal hamster = new Animal();
            hamster.Name = "Hamster";
            hamster.Description = "desc";

            animal.Add(hamster);

            Animal koala = new Animal();
            koala.Name = "Koala";
            koala.Description = "desc";

            animal.Add(koala);

            dogButton.TouchUpInside += (s, e) =>
            {
                //selectedAnimal = animal.Find(x => x.Name == "Dog");
                selectedAnimal.Name = "Dog";
            };

            catButton.TouchUpInside += (s, e) =>
            {
                //selectedAnimal = animal.Find(x => x.Name == "Cat");
                selectedAnimal.Name = "Cat";
            };

            hamsterButton.TouchUpInside += (s, e) =>
            {
                //selectedAnimal = animal.Find(x => x.Name == "Hamster");
                selectedAnimal.Name = "Hamster";
            };

            koalaButton.TouchUpInside += (s, e) =>
            {
                //selectedAnimal = animal.Find(x => x.Name == "Koala");
                selectedAnimal.Name = "Koala";
            };
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var animalVC = segue.DestinationViewController as AnimalDetailViewController;
            if (animalVC != null)
                animalVC.animal = selectedAnimal;
        }
    }
}