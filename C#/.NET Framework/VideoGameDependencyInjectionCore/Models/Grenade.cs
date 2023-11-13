using System;
using System.Collections.Generic;
using System.Text;
using VideoGameDependencyInjectionCore.Interfaces;

namespace VideoGameDependencyInjectionCore.Models
{
    class Grenade : IWeapon
    {
        public string WeaponName { get; set; }

        public Grenade(string weaponName)
        {
            WeaponName = weaponName;
        }

        public Grenade()
        {
            WeaponName = "Pathetic grenade. No name provided";
        }

        public void AttackWithMe()
        {
            Console.WriteLine(WeaponName + " sizzles for a moment and then explodes into a shower of deadly metal fragments.");
        }
    }
}
