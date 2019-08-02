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
                selectedAnimal.Description = "A dog is a man's best friend! They are loyal and they will love you for their lifetime." +
                "They have thick furs which protect them from weather. They bark, woof, or growl whenever they want." +
                "Dogs usually want you to rub their belly and play with them.";

            };

            catButton.TouchUpInside += (s, e) =>
            {
                //selectedAnimal = animal.Find(x => x.Name == "Cat");
                selectedAnimal.Name = "Cat";
                selectedAnimal.Description = "Cats are moody. They usually stay in a corner. Most of the time they just ignore you." +
                "They have sharp paws which could they use to destroy your new sofa. Nonetheless, some of them are still cute. " +
                "You will love them no matter what.";
            };

            hamsterButton.TouchUpInside += (s, e) =>
            {
                //selectedAnimal = animal.Find(x => x.Name == "Hamster");
                selectedAnimal.Name = "Hamster";
                selectedAnimal.Description = "Hamsters are small and cute. They are like a fur ball. Always running around and using" +
                " their cute little teeths to chew. They love to play around and you can hold them on your little hands. I would be nice " +
                "if you have one or two and give them a cute little house of their own.";
            };

            koalaButton.TouchUpInside += (s, e) =>
            {
                //selectedAnimal = animal.Find(x => x.Name == "Koala");
                selectedAnimal.Name = "Koala";
                selectedAnimal.Description = "Koalas are also cute. They live on the trees. Eat on the trees. Sleep on the trees." +
                "They'll climb trees and stay there for long. ";
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