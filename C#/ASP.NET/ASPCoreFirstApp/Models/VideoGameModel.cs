using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreFirstApp.Models
{
    public class VideoGameModel
    {
        //Declare variables.
        [DisplayName("Name of the game.")]
        public string Name { get; set; }
        [DisplayName("Genre the game belongs to most.")]
        public string Genre { get; set; }
        [DisplayName("Price for purchasing the game.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DisplayName("Developer of the game.")]
        public string Developer { get; set; }
        [DisplayName("Console the game is available on.")]
        public string Console { get; set; }
        [DisplayName("Date the game was released.")]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }

        //Create constructors
        public VideoGameModel(string name, string genre, decimal price, string developer, string console, DateTime releaseDate)
        {
            Name = name;
            Genre = genre;
            Price = price;
            Developer = developer;
            Console = console;
            ReleaseDate = releaseDate;
        }
        public VideoGameModel()
        {

        }

    }
}
