using System;
using System.Collections.Generic;
using System.Text;

namespace Activity2._2
{
    class Cow : Animal, IRidable, IMilkable, IDomesticated
    {
        public Cow()
        {
            Console.WriteLine("I am a cow!");
        }
        //New Talk method spefic to this class.
        public new void Talk()
        {
            Console.WriteLine("Moo!");
        }
        //Overide the Animal Sing() method.
        public override void Sing()
        {
            Console.WriteLine("Cows do not sing");
        }
        //Implement the IMilkable interface.
        public void Milk()
        {
            Console.WriteLine("Milking a cow");
        }
        //Implement the IRidable interface.
        public void Ride()
        {
            Console.WriteLine("Cows are ridable but it is not recommended.");
        }

        public void Speed()
        {
            Console.WriteLine("Cows go medium speed");
        }
        //Implement the IDomesticated interface.
        public void TouchMe()
        {
            Console.WriteLine("You can pet me, just be careful");
        }

        public void FeedMe()
        {
            Console.WriteLine("My favorite thing to eat is grass!");
        }
    }
}
