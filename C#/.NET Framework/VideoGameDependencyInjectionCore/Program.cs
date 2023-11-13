using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using VideoGameDependencyInjectionCore.Models;
using VideoGameDependencyInjectionCore.Interfaces;

namespace VideoGameDependencyInjectionCore
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            HeroThatOnlyUsesSwords hero1 = new HeroThatOnlyUsesSwords("Ultraman");
            hero1.Attack();
            Console.WriteLine();

            HeroThatCanUseAnyWeapon hero2 = new HeroThatCanUseAnyWeapon("Eregon", new Sword("Brisinger"));
            hero2.Attack();
            Console.WriteLine();

            HeroThatCanUseAnyWeapon hero3 = new HeroThatCanUseAnyWeapon("The Joker", new Grenade("The Pineapple"));
            hero3.Attack();
            Console.WriteLine();

            HeroThatCanUseAnyWeapon hero4 = new HeroThatCanUseAnyWeapon("GI Joe", new Gun("Six Shooter",
                new List<Bullet>
                {
                    new Bullet("Silver Slug", 10),
                    new Bullet("Lead Ball", 20),
                    new Bullet("Rusty Nail", 3),
                    new Bullet("Hollow Point", 5)
                }));
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            hero4.Attack();
            */

            //CONFIGURATION FILE
            // In an ASP.NET program this section usually sits in a configuration file like Startup.cs
            // we will modify the contents of this startup section.

            // ServiceCollection is the "container" of all registered dependencies
            ServiceCollection services = new ServiceCollection();

            // All new weapons will now be Grenades by default.
            //services.AddTransient<IWeapon, Grenade>(grenade => new Grenade("Exploding Pen"));
            //services.AddTransient<IWeapon, Sword>(s => new Sword("The Sword of Gryffindor"));
            services.AddTransient<IWeapon, Gun>(g => new Gun("Six Shooter",
                new List<Bullet>
                {
                    new Bullet("Silver Slug", 10),
                    new Bullet("Lead Ball", 20),
                    new Bullet("Rusty Nail", 3),
                    new Bullet("Hollow Point", 5)
                }));

            //All new heroes will be "Jonny" by default.
            services.AddTransient<IHero, HeroThatCanUseAnyWeapon>(hero => new HeroThatCanUseAnyWeapon("Jonny English", hero.GetService<IWeapon>()));

            // Sort of a "compile" step to assemble everything listed above.
            ServiceProvider provider = services.BuildServiceProvider();

            //IMPLEMENTATION
            // based on all of the configuration above, we can create a new hero in one, small step.
            var hero5 = provider.GetService<IHero>();

            //let's see if it works...
            hero5.Attack();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
