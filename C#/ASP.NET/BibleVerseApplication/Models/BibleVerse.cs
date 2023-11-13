/***
 * Author: Raymond Lawson
 * Purpose: This is the model class that will be used with the database to create a bible verse object.
 * Date: 06/20/2023
 * ***/
namespace BibleVerseApplication.Models
{
    public class BibleVerse
    {
        //Declare variables
        public int Id { get; set; } 
        public int Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Text { get; set; }
        public string Testament { get; set; }

        //Create constructors
        public BibleVerse()
        {

        }
        public BibleVerse(int id, int book, int chapter, int verse, string text, string testament)
        {
            Id = id;
            Book = book;
            Chapter = chapter;
            Verse = verse;
            Text = text;
            Testament = testament;
        }
    }
}
