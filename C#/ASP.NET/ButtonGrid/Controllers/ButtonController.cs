using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ButtonGrid.Models;

namespace ButtonGrid.Controllers
{
    public class ButtonController : Controller
    {
        //create list of buttons
        static List<ButtonModel> buttons = new List<ButtonModel>();
        Random rand = new Random();
        const int GRID_SIZE = 25;


        public IActionResult Index()
        {
            //empty the list when the page loads
            buttons = new List<ButtonModel>();

            //Generate some new buttons. Randmly chosen color values.
            for (int i = 0; i < GRID_SIZE; i++)
            {
                buttons.Add(new ButtonModel(i, rand.Next(3)));
            }

            //send the button list to the "Index" page
            return View("Index", buttons);
        }

        public IActionResult HandleButtonClick(string buttonNumber)
        {
            //convert from string to int
            int bN = int.Parse(buttonNumber);

            //add one to the button state. If greater than 4, reset to 0
            buttons.ElementAt(bN).ButtonState = (buttons.ElementAt(bN).ButtonState + 1) % 3;

            for (int i = 0; i < buttons.Count; i++)
            {
                //Check the first in the list differently
                if(i == 0)
                {
                    if(buttons.ElementAt(i).ButtonState == buttons.ElementAt(i + 1).ButtonState)
                    {
                        buttons.ElementAt(i).Equal = true;
                    }
                    else
                    {
                        buttons.ElementAt(i).Equal = false;
                    }
                }
                //Check the rest of the buttons
                if(i > 0)
                {
                    if(buttons.ElementAt(i).ButtonState == buttons.ElementAt(i - 1).ButtonState)
                    {
                        buttons.ElementAt(i).Equal = true;
                    }
                    else
                    {
                        buttons.ElementAt(i).Equal = false;
                    }
                }
            }
            //re-display the buttons
            return View("Index", buttons);
        }

        public IActionResult ShowOneButton(int buttonNumber)
        {
            //add one to the button state. If greater than 3, reset to 0.
            buttons.ElementAt(buttonNumber).ButtonState = (buttons.ElementAt(buttonNumber).ButtonState + 1) % 3;

            // re-display the button that was clicked
            return PartialView(buttons.ElementAt(buttonNumber));
        }

        public string AreAllEqual()
        {
            
            int counter = 0;
            string returnString = "";
            for (int i = 0; i < buttons.Count; i++)
            {
                //Check the first in the list differently
                if (i == 0)
                {
                    if (buttons.ElementAt(i).ButtonState == buttons.ElementAt(i + 1).ButtonState)
                    {
                        buttons.ElementAt(i).Equal = true;
                    }
                    else
                    {
                        buttons.ElementAt(i).Equal = false;
                    }
                }
                //Check the rest of the buttons
                if (i > 0)
                {
                    if (buttons.ElementAt(i).ButtonState == buttons.ElementAt(i - 1).ButtonState)
                    {
                        buttons.ElementAt(i).Equal = true;
                    }
                    else
                    {
                        buttons.ElementAt(i).Equal = false;
                    }
                }
            }

            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons.ElementAt(i).Equal)
                {
                    counter++;
                }
            }
            if(counter == buttons.Count)
            {
                returnString = "Congratulations! All the buttons match!";
            }
            else
            {
                returnString = " Not all buttons are the same color. See if you can make them all match.";
            }

            return returnString;
        }

        public IActionResult RightClickShowOneButton(int buttonNumber)
        {
            //on right click, always reset to 0
            buttons.ElementAt(buttonNumber).ButtonState = 0;

            //re-display the button that was clicked
            return PartialView("ShowOneButton", buttons.ElementAt(buttonNumber));
        }
    }
}
