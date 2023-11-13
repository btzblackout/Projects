using System;
using System.Collections.Generic;
using System.Text;
using VideoGameDependencyInjectionCore.Interfaces;

namespace VideoGameDependencyInjectionCore.Models
{
    class HeroThatOnlyUsesSwords : IHero
    {
        public string Name { get; set; }
        public HeroThatOnlyUsesSwords(string name)
        {
            Name = name;
        }
        public HeroThatOnlyUsesSwords()
        {
            Name = "Generic Hero. No name given.";
        }

        public void Attack()
        {
            //do it wrong the first time. Later demonstrate dependency injection.
            //When you see a "new" object in a class, you have just created a strong dependency.
            //In this case, because we instantiated a sword inside the hero,
            //the hero can no longer exist without a sword.

            Sword sword = new Sword("Excalibur");
            Console.WriteLine(Name + " prepares himself for the battle.");
            sword.AttackWithMe();
        }
    }
}
