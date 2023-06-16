using System;
using System.Linq;

namespace LINQdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make some test scores.
            int[] scores = new[] { 50, 66, 99, 81, 77, 45, 0, 100, 99, 72, 87, 85, 81, 80, 77, 74, 95, 97};

            //Print the scores.
            foreach (var individualScore in scores )
            {
                Console.WriteLine("One of the scores was {0}", individualScore);
            }

            //Pause to see the output before closing.
            Console.ReadLine();

            //Use a LINQ statement to filter the list.
            var theBestStudents =
                from individualScore in scores
                where individualScore > 90
                select individualScore;
            //Print only the bestscores.
            foreach (var individualScore in theBestStudents)
            {
                Console.WriteLine("One of the BEST scores was {0}", individualScore);
            }
            //Pause to see the output before closing
            Console.ReadLine();

            //Use LINQ to sort the results
            var sortedScores =
                from individualScore in scores
                orderby individualScore
                select individualScore;
            //Print the sorted list
            foreach (var individualScore in sortedScores)
            {
                Console.WriteLine("One of the scores was {0}", individualScore);
            }
            //Pause to see the output before closing
            Console.ReadLine();

            //PRINT A LIST OF ONLY B STUDENTS (80 - 89) IN ASCENDING ORDER
            var bStudents =
                from grade in scores
                where grade > 79 && grade < 90
                orderby grade
                select grade;
            //Print the sorted list.
            foreach (var grade in bStudents)
            {
                Console.WriteLine("B student grade: " + grade);
            }

            Console.ReadLine();

            //Create arraylist of students
            Student[] students = new Student[6];
            students[0] = new Student("Bob", 20, 20);
            students[1] = new Student("Mary", 38, 80);
            students[2] = new Student("Vinny", 31, 50);
            students[3] = new Student("Paul", 19, 100);
            students[4] = new Student("Patricia", 38, 80);
            students[5] = new Student("May", 26, 100);

            var studentList =
                from student in students
                orderby student
                select student;
            //Print the sorted students
            foreach(var student in studentList)
            {
                Console.WriteLine("Name: " + student.name + " Age: " + student.age + " Grade: " + student.grade);
            }

        }
    }
}
