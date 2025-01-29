using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_lab_4
{
    internal class Cow : Animal
    {
        public Cow(string name) : base ( name) { }
        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine("Moo Moo");
        }
        public void GiveMilk()
        {
            Console.WriteLine("the cow  gives milk");
        }
    }
}
