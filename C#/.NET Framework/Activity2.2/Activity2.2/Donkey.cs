using System;
using System.Collections.Generic;
using System.Text;

namespace Activity2._2
{
    class Donkey : Animal, IRidable, IDomesticated
    {
        public Donkey()
        {
            Console.WriteLine("I am a donkey.");
        }
        //New Talk method specific for this class.
        public new void Talk()
        {
            Console.WriteLine("Bray!");
        }
        //Override the Animal Sing method.
        public override void Sing()
        {
            Console.WriteLine("Hee-Haw");
        }
        //Implement the IRidable interface.
        public void Ride()
        {
            Console.WriteLine("You are riding a donkey.");
        }
        public void Speed()
        {
            Console.WriteLine("Donkeys are very slow.");
        }
        //Implement the IDomesticated interface
        public void TouchMe()
        {
            Console.WriteLine("My coat may be a bit tough!");
        }

        public void FeedMe()
        {
            Console.WriteLine("Donkeys eat similar to a horse - hay, straw, and grass.");
        }
    }
}
