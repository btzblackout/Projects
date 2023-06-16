//Corrected by <Raymond Lawson>
/*
 * I mainly used two debugging techniques: 
 * 1. Placing Console.WriteLine() in several places to observe if methods and statements/loops were executing properly
 *      a. This method allows me to visually see what is executing and what isn't. If a console output executes that is located inside an if
 *      statement then I know the if statement condition is working properly, and the if statement is firing. 
 * 2. Stepping through the executing of the code (using F11).
 *      a. This method allows me to slow down the execution and step through each part of the program as it's executing. 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise_9
{
    class Set
    {
        bool alreadyContained = false;
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        /*
         * The issue before changing this method:
         * The for loop was not executing correctly. 
         * I have chosen to instead of returning true or false values to sticking with a bool 
         * variable that is returned. The bool is set to false by default, as well as each new time the method is ran. If, during the iteration
         * of the for loop any number is the same then the bool is set to true. It is returned at the end of the method.
         */
        private bool containsElement(int val)
        {
            //Set the (alreadyContained) bool to false on each new run of the method.
            alreadyContained = false;

            for (int i = 0; i < elements.Count; i++)
            {
                //Removed the if else statement below. Instead of returning true or false I have chosen to return a bool variable.
                //The if statement now sets the bool to true if it fires, and the bool is returned at the end of the method.
                //if (val == elements[i])
                //    return true;
                //else
                //    return false;
                if( val == elements[i])
                {
                    alreadyContained = true;
                }
            }
            //As stated above, I have opted for removing returning true or false, instead returning a bool variable.
            //return false;
            return alreadyContained;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        /*
         * The issue before changing this method:
         * When using this method as (A.union(B)), list B would be added to list A, and list B was being returned.
         * For the solution I have implemented a third object called unionReturn to hold the union list, as well as to be returned for display.
         * This way both A and B are added to the unionReturn object, while keeping their original numbers.
         */
        public Set union(Set rhs)
        {
            //I added a new object that will be used for the union return.
            Set unionReturn = new Set();
            
            //Since I decided to go with a third, union list, I have added this for loop to add the first list to the union list.
            for (int i = 0; i < this.elements.Count; i++)
            {
                unionReturn.addElement(this.elements[i]);
            }

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                //This line added the 2nd list to the 1st, changing the 1st.
                //this.addElement(rhs.elements[i]);
                unionReturn.addElement(rhs.elements[i]);
            }
            //This would have returned the second list, not the union list.
            //return rhs
            return unionReturn;
        }
    }


}

