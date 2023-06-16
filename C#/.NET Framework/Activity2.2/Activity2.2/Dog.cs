using System;
using System.Collections.Generic;
using System.Text;

namespace Activity2._2
{
    class Dog : Animal, IDomesticated
    {
        public Dog()
        {
            Console.WriteLine("Dog constructor. Good puppy.");
        }
        public new void Talk()
        {
            Console.WriteLine("Bark Bark Bark");
        }
        public override void Sing()
        {
            Console.WriteLine("Hooowwwl!");
        }
        public void Fetch(string thing)
        {
            Console.WriteLine("Oh boy. Here is your " + thing + ". Let's do it again!");
        }

        public void TouchMe()
        {
            Console.WriteLine("Please scratch behind my ears.");
        }

        public void FeedMe()
        {
            Console.WriteLine("It's suppertime. The very best time of the day!!!");
        }
    }
}
