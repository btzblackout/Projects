using System;
using System.Collections.Generic;
using System.Text;
using VideoGameDependencyInjectionCore.Interfaces;

namespace VideoGameDependencyInjectionCore.Models
{
    class Sword : IWeapon
    {
        public string SwordName { get; set; }

        public Sword(string swordName)
        {
            SwordName = swordName;
        }

        public Sword()
        {
            SwordName = "Lame name sword";
        }

        public void AttackWithMe()
        {
            System.Console.WriteLine(SwordName + " slices through the air, devistating all enemies");
        }
    }
}
