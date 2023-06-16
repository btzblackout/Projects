using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        //This is a simple main method for testing the other two methods below. 
        public static void main(String[] args)
        {
            Console.WriteLine("There are " + FatCalories(5) + " calories from 5 grams of fat!");
            Console.WriteLine("There are " + CarbCalories(10) + " calories from 10 grams of carbs!");
        }

        /*
         * This method:
         * Takes an int - fatGrams
         * Performs logic with the int - calories = fatGrams * 9
         * Returns an int - calories
         */
        public static int FatCalories(int fatGrams)
        {
            int calories = fatGrams * 9;
            return calories;
        }

        /*
         * This method: 
         * Takes in an int - carbGrams
         * Performs logic using the int - calories = carbGrams * 4
         * Returns an int - calories
         */
        public static int CarbCalories(int carbGrams)
        {
            int calories = carbGrams * 4;
            return calories;
        }
    }
}
