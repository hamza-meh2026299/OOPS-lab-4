using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_lab_4
{
    internal class Dog : Animal
    {
        public Dog(string name) : base ( name)
        { }

        public override void Speak()
        {
            //base.Speak(name, speech);
            Console.WriteLine("woof! woof!");
        }

        public void Fetch()
        {
            Console.WriteLine("The dog is fetching the ball");
        }
    }
}
