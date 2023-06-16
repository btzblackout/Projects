using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextFileDataAccessDemo
{
    class Program
    {
        static string issueLine;
        static int counter = 0;
        static void Main(string[] args)
        {
            string filePath = @"C:\demos\test.txt";
            /*
            List<String> lines = File.ReadAllLines(filePath).ToList();
            lines.Add("Jeff, Bezos, www.Amazon.com");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines(filePath, lines);
            */

            List<Person> people = new List<Person>();

            //Error checking to make sure the file exists.
            if(File.Exists(filePath))
            {
                List<String> lines = File.ReadAllLines(filePath).ToList();
                foreach (string line in lines)
                {
                    try
                    {
                        //Ensure each line is formatted correctly.
                        //First, store the line in a CHAR array.
                        char[] errorChecking = line.ToCharArray();
                        //Parse through the char array.
                        for (int i = 0; i < errorChecking.Length; i++)
                        {
                            //Check for a ','
                            if(errorChecking[i] == ',')
                            {
                                //When one is found, increase the counter variable.
                                counter++;
                            }
                        }
                        //If the counter variable is less than 3 that line is the problem.
                        //Since this happens before the code that throws the error we can save the line that is the problem and call it in the catch.
                        if (counter > 2)
                        {
                            issueLine = line;
                        }
                        string[] entries = line.Split(',');

                        Person p = new Person();
                        p.firstName = entries[0];
                        p.lastName = entries[1];
                        p.Url = entries[2];

                        people.Add(p);
                    }
                    catch(IndexOutOfRangeException e)
                    {
                        Console.WriteLine("The line: " + issueLine + ". Is not formatted correctly.");
                    }
                    
                }
            }
            //Print a list of people and save the list to another file.

            //Output lines will be used to save to the file.
            List<string> outputLines = new List<string>();
            Console.WriteLine("Here is the list of people I have:");
            foreach(Person p in people)
            {
                //First print to the console.
                Console.WriteLine("First name: " + p.firstName + " Last Name: " + p.lastName + " URL: " + p.Url);

                //add another line for the file output.
                outputLines.Add("First Name: " + p.firstName + " Last Name: " + p.lastName + " URL: " + p.Url + "\n");
            }

            //Write to another file.
            string outPath = @"C:\demos\peopleOut.txt";
            File.WriteAllLines(outPath, outputLines);
            Console.ReadLine();
        }
    }
}
