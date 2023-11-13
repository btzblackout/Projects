/***
 * Author: Raymond Lawson
 * Purpose: This is the BibleController class. This class is the middle man between the view and the model.
 * The users will send a request to this controller, along with required data and the controller will
 * pass the data to the appropriate service. When this controller recieves a response from the service it will
 * pass the data and the correct view along to the user.
 * Date: 06/20/2023
 * ***/
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using BibleVerseApplication.Models;
using BibleVerseApplication.Services.Business;
namespace BibleVerseApplication.Controllers
{
    public class BibleController : Controller
    {
        //Create an instance of the service class.
        BibleVerseService service = new BibleVerseService();
        public IActionResult Index()
        {
            //Create a new instance of the BibleVerse object and pass it to the view.
            BibleVerse verse = new BibleVerse();

            //Set this so the radio button for Both will be checked by default when the view loads.
            verse.Testament = "Both";

            return View(verse);
        }

        [HttpPost]
        public IActionResult SearchForVerse(BibleVerse verse)
        {
            //Call the method SearchByTerm in the service class and pass the verse object as a parameter.
            //Also, create a List of BibleVerses to hold the response.
            List<BibleVerse> verseList = service.SearchByTerm(verse);

            //Check if the list is empty or null.
            if(verseList.Count() == 0 || verseList == null)
            {
                return View("EmptyList");
            }

            return View(verseList);
        }
    }
}
