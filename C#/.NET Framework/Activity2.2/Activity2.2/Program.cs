using System;

namespace Activity2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Animal beast = new Animal();
            beast.Talk();
            beast.Greet();
            beast.Sing();
            */

            Dog bowser = new Dog();
            bowser.Talk();
            bowser.Greet();
            bowser.Sing();
            bowser.Fetch("stick");
            bowser.FeedMe();
            bowser.TouchMe();

            Robin red = new Robin();
            red.Talk();
            red.Greet();
            red.Sing();
            //red.Fetch("worm");
            //red.FeedMe();
            //red.TouchMe();

            //Horse class. Inherits from Animal class and implements the IRidable and IDomesticated interfaces.
            Horse tony = new Horse();
            tony.Talk();
            tony.Greet();
            tony.Sing();
            tony.Ride();
            tony.Speed();
            tony.TouchMe();
            tony.FeedMe();

            //Donkey class. Inherits from Animal class and implements the IRidable and IDomesticated interfaces.
            Donkey donkey = new Donkey();
            donkey.Talk();
            donkey.Greet();
            donkey.Sing();
            donkey.Ride();
            donkey.Speed();

            //Cow class. Inherits from Animal class and implements the IRidable, IMilkable, and IDomesticated interfaces.
            Cow bessy = new Cow();
            bessy.Talk();
            bessy.Greet();
            bessy.Sing();
            bessy.Milk();
            bessy.Ride();
            bessy.Speed();
            Console.ReadLine();
        }
    }
}
