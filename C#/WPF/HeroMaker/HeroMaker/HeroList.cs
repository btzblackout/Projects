using System;
using System.Collections.Generic;
using System.Text;

namespace HeroMaker
{
    public class HeroList
    {
        //Declare variables.
        private List<SuperHero> superHeroList = new List<SuperHero>();
        
        //Constructor
        public HeroList()
        {
        }

        //Add a superhero to the list.
        public void addSuperHero(SuperHero hero)
        {
            superHeroList.Add(hero);
        }
        //Return the superhero list.
        public List<SuperHero> getSuperHeroList()
        {
            return superHeroList;
        }
    }
}
