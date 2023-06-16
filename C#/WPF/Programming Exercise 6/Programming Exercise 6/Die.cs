using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Exercise_6
{
    class Die
    {
        private int numberOfSides;
        private int sideFacingUp;
        

        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
        }
        
        public Die()
        {

        }
        public int getNumberOfSides()
        {
            return numberOfSides;
        }
        public void setNumberOfSides(int numberofSides)
        {
            this.numberOfSides = numberofSides;
        }
        public int getSideFacingUp()
        {
            return sideFacingUp;
        }
        public int RollDie(Random rand)
        {
            sideFacingUp = rand.Next(1, numberOfSides + 1);
            return sideFacingUp;
        }
    }
}
