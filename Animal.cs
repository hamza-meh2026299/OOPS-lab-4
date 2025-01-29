using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_lab_4
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine("The animal is speaking");
        }
        public void Move()
        {
            Console.WriteLine("the animal moving");
        }
        public void Eat()
        {
            Console.WriteLine("Animal is eating food");
        }
        public void Eat( string food)
        {
            Console.WriteLine($"The animat is eating{food}");
        }
    }
}
