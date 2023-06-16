using System;
using System.Collections.Generic;
using System.Text;

namespace Activity2._2
{
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("\nAnimal constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal says Hello");
        }
        public void Talk()
        {
            Console.WriteLine("Animal talking");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }
    }
}
