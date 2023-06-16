using System;
using System.Collections.Generic;
using System.Text;

namespace Activity2._2
{
    class Horse : Animal, IRidable, IDomesticated
    {

        public Horse()
        {
            Console.WriteLine("I am a horse.");
        }
        //New Talk method specific to this class.
        public new void Talk()
        {
            Console.WriteLine("Neigh!");
        }
        //Override the Animal Sing method.
        public override void Sing()
        {
            Console.WriteLine("Horses do not sing");
        }
        //Implement the IRidable interface.
        public void Ride()
        {
            Console.WriteLine("You are riding a horse!");
        }

        public void Speed()
        {
            Console.WriteLine("Horses are very fast.");
        }
        //Implement the IDomesticated interface.
        public void TouchMe()
        {
            Console.WriteLine("I like being brushed!");
        }

        public void FeedMe()
        {
            Console.WriteLine("Horses eat hay.");
        }
    }
}
