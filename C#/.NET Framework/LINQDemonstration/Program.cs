using System;
using System.Linq;
namespace LINQDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            // make some test scores
            int[] scores = new[] { 50, 66, 90, 81, 77, 45, 0, 100, 99, 72, 87, 85, 81, 80, 77, 74, 95, 97 };

            // Print the scores
            foreach(var individualScore in scores)
            {
                Console.WriteLine("One of the scores was {0}", individualScore);
            }

            // Use a LINQ statement to filter the list
            var theBestStudents = from individualScore in scores where individualScore > 90 select individualScore;
            
            // Print only the best scores
            foreach(var individualScore in theBestStudents)
            {
                Console.WriteLine("One of the BEST scores was {0}", individualScore);
            }

            // Pause to see the output before closing
            Console.ReadLine();

            //use LINQ to sort the array
            var sortedScores = from individualScore in scores orderby individualScore select individualScore;

            // Print the sorted list.
            foreach(var individualScore in sortedScores)
            {
                Console.WriteLine("One of the scores was {0}", individualScore);
            }

            // Pause to see the output before closing
            Console.ReadLine();

            //Challenge 1: Print a list of only B students (80 - 89) in ascending order.

            // Get the list of B students
            var listOfBStudents = from individualScore in scores where individualScore >= 80 && individualScore <= 89 select individualScore;

            // Sort the list in ascending order.
            var sortedBList = from individualScore in listOfBStudents orderby individualScore select individualScore;

            // Print the list
            foreach(var individualScore in sortedBList)
            {
                Console.WriteLine("One of the scores in the B list was {0}", individualScore);
            }

            //Pause to see the output
            Console.ReadLine();
        }
    }
}
