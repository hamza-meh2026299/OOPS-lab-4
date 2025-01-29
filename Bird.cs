using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_lab_4
{
    internal class Bird : Animal
    {
        public Bird(string name) : base(name) { }
        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine("Tweet Tweet");
        }
        //public void implemmentsflying()
        //{
        //    Console.WriteLine("the bird is flying");
        //}
    }
    
}
