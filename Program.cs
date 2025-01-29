using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = {
            new Dog("Buddy"),
            new Cat("Whiskers"),
            new Cow("Bessie"),
            new Bird("Tweety")
        };

            foreach (var animal in animals)
            {
                Console.WriteLine($"Animal: {animal.Name}");
                animal.Speak();
                animal.Move();
                animal.Eat();
                animal.Eat("grass");
                Console.WriteLine();
            }

            Dog dog = new Dog("Rex");
            dog.Fetch();

            Cat cat = new Cat("Kitty");
            cat.Scratch();

            Cow cow = new Cow("Daisy");
            cow.GiveMilk();

        }
    }
}
