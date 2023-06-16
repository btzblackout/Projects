using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ButtonGrid.Models
{
    public class ButtonModel
    {
        public int Id { get; set; }
        public int ButtonState { get; set; }

        public bool Equal { get; set; }

        public ButtonModel()
        {

        }
        public ButtonModel(int id, int buttonState)
        {
            Id = id;
            ButtonState = buttonState;
            Equal = false;
        }
    }
}
