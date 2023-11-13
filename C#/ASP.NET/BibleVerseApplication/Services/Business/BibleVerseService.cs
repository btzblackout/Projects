/***
 * Author: Raymond Lawson
 * Purpose: This is the BibleVerseService class. This class is the middleman between the controller and the DAO class.
 * The controller will pass the data to this class and it will send it on to the DAO for database processing, when the
 * DAO returns a result it will pass it back to the controller.
 * Date: 06/20/2023
 * ***/
using System.Collections.Generic;
using BibleVerseApplication.Models;
using BibleVerseApplication.Services.Data;
namespace BibleVerseApplication.Services.Business
{
    public class BibleVerseService
    {
        public List<BibleVerse> SearchByTerm(BibleVerse verse)
        {
            //Create an instance of the DAO class
            BibleVerseDAO bibleVerseDAO = new BibleVerseDAO();

            //Call the Search method in the DAO and pass verse as a parameter. 
            //Store the method return in a List of BibleVerse objects
            List<BibleVerse> verseList = bibleVerseDAO.Search(verse);

            //return the BibleVerse List
            return verseList;
        }
    }
}
