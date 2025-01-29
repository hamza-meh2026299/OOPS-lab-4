using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_lab_4
{
    internal class Cat: Animal
    {

        public Cat(string name) : base(name) { }
        public override void Speak()
        {
            Console.WriteLine("Meow Meow");
        }
        public void Scratch()
        {
            Console.WriteLine("The cat is scatching the furniture");
        }
    }
}
