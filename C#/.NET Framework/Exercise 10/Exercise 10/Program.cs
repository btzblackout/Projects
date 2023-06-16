using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The text file has " + CheckForChars() + " words that end in either a t or an e." );
            Console.ReadLine();
        }
        
        //This method takes in the text file (TextFile.txt) in the /bin/debug folder. It stores all the file into a string, then parses the string, removing
        //the delimeters from the char array and stores the remaining words into a string array. Each element in the string array is then converted to a char
        //array and its last element is tested against the letters e and t. If either are true then the count variable is increased. It returns the 
        //count variable at the end. 
        public static int CheckForChars()
        {
            string sentence = System.IO.File.ReadAllText(@"TextFile.txt");
            int counter = 0;
            char[] delimeters = { ' ', ',', '.'};
            string[] stringList = sentence.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in stringList)
            {
                char[] charArray = s.ToCharArray();
                int max = charArray.Length - 1;
                if(charArray[max] == 't' || charArray[max] == 'e')
                {
                    counter++;
                }
            }          
            return counter;
        }
    }
}
