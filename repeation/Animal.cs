using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmas_tree
{
   abstract class Animal
    {
        public abstract void AnimalSound();

        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }

    }
}
