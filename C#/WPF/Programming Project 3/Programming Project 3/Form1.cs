using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Programming_Project_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {  
            
            string file = openFileDialog1.FileName;
            textBox1.Text = openFileDialog1.SafeFileName;
            string placeholder;
            string newline = Environment.NewLine;
            textBox2.Clear();
            StreamReader sr;
            sr = File.OpenText(file);
            textBox2.Text = textBox2.Text + "THE ORIGINAL TEXT IN THE FILE." + "\r\n";
            while (sr.Peek() >= 0)
            {

                placeholder = sr.ReadLine();
                /* 
                 * This part is laid out in two statements because for some reason
                 * having only one statmene that was "textBox3.Text + Environment.NewLine + placeholder"
                 * caused blank lines to appear at the top of the textbox above everything as well as providing
                 * me with the formatting I wished to have.After much testing this is the workaround that does 
                 * not cause blank spaces at the top and still allows me to have the formatting I want.
                 */
                textBox2.Text = textBox2.Text + newline;
                textBox2.Text = textBox2.Text + placeholder;
            }
            sr.Close();

            sr = File.OpenText(file);
            textBox2.Text = textBox2.Text + "\r\n" + "\r\n" + "1. ALL TEXT TO LOWERCASE." + "\r\n";
            while (sr.Peek() >= 0)
            {
                placeholder = sr.ReadLine();
                textBox2.Text = textBox2.Text + newline;
                textBox2.Text = textBox2.Text + placeholder.ToLower();

            }
            sr.Close();

            sr = File.OpenText(file);

            /* 
             * Below finds the first and last words alphabetically.
             * I declare the variables first.
             * Then I read a line to a string called placeholder
             * Each word in the string is copied to an array using the Split() method.
             * The array is copied to a list.
             * The Sort() method is used on the list.
             * I pull the first and last indexes from the list
             * I convert the list back to a string to display the entire thing.
             */

            textBox2.Text = textBox2.Text + "\r\n" + "\r\n" + "2. FIND THE FIRST AND LAST WORDS ALPHABETICALLY." + "\r\n" + "\r\n";

            List<string> words = new List<string>();
            string[] placeholderArray;
            string test = "";

            while (sr.Peek() >= 0)
            {
                placeholder = sr.ReadLine();
                placeholderArray = placeholder.Split(' ');
                for (int i = 0; i <= placeholderArray.Length - 1; i++)
                {
                    words.Add(placeholderArray[i]);
                }
            }
            sr.Close();
            words.Sort();
            string first = words[0];
            string last = words[words.Count - 1];
            foreach (object o in words)
            {
                test = test + " " + o;
            }

            textBox2.Text = textBox2.Text + "The first word alphabetically is: " + first + " and the last is: " + last;

            /*
             * Below my program finds the longest word.
             * First I declare the variables.
             * Next I enter a loop to travers the words List.
             * I compare the length of each of the words in the "words" List.
             * If the length of a word is longer than the current longest then it becomes the longest word
             */
            textBox2.Text = textBox2.Text + "\r\n" + "\r\n" + "3. FIND THE LONGEST WORD." + "\r\n" + "\r\n";

            int longestCounter = 0;
            String longestWord = "test";
            for (int i = 0; i < words.Count; i++)
            {

                if (words[i].Length > longestCounter)
                {
                    longestCounter = words[i].Length;
                    longestWord = words[i];
                }

            }
            textBox2.Text = textBox2.Text + "The longest word is: " + longestWord + "\r\n";

            /* 
             * Below my program finds the word with the most vowels.
             * First I declared the variables.
             * Next I enter a for loop to travers the entire "words" List
             * I then declare more variables that are used as counters for each vowel.
             * I convert each word to a character array (I used the same array for every word).
             * I compare each character in the character arrays to specific characters using if statements
             * If a letter matches a vowel the counter increases
             * At the end of the word I tally up all counters and if it has more vowels than the current
             * largest then it becomes the largest.
             */
            textBox2.Text = textBox2.Text + "\r\n" + "4. FIND THE WORD WITH THE MOST VOWELS." + "\r\n" + "\r\n";

            int mostVowels = 0;
            string word = "";
            char[] charArray;
            
            for (int i = 0; i < words.Count; i++)
            {
                int aCounter = 0;
                int eCounter = 0;
                int iCounter = 0;
                int oCounter = 0;
                int uCounter = 0;
                int totalVowels = 0;

                charArray = words[i].ToCharArray();
                for (int j = 0; j < charArray.Length; j++)
                {
                    if (charArray[j] == 'a' || charArray[j] == 'A')
                    {
                        aCounter += 1;
                    }
                    if (charArray[j] == 'e' || charArray[j] == 'E')
                    {
                        eCounter += 1;
                    }
                    if (charArray[j] == 'i' || charArray[j] == 'I')
                    {
                        iCounter += 1;
                    }
                    if (charArray[j] == 'o' || charArray[j] == 'O')
                    {
                        oCounter += 1;
                    }
                    if (charArray[j] == 'u' || charArray[j] == 'U')
                    {
                        uCounter += 1;
                    }
                }

                totalVowels = aCounter + eCounter + iCounter + oCounter + uCounter;

                if (totalVowels > mostVowels)
                {
                    mostVowels = totalVowels;
                    word = words[i];
                }
            }
            textBox2.Text = textBox2.Text + "The word with the most vowels is: " + word + " with " + mostVowels + " vowels.\r\n";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter output;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                output = File.CreateText(saveFileDialog1.FileName);
                output.WriteLine(textBox2.Text);
                output.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
