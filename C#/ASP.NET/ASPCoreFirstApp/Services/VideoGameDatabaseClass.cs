using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreFirstApp.Models;
using Bogus;

namespace ASPCoreFirstApp.Services
{
    public class VideoGameDatabaseClass
    {
        //Declare variables.
        static List<VideoGameModel> videoGameList;          //Static so the data does not change.

        //Create constructor

        public VideoGameDatabaseClass()
        {
            videoGameList = new List<VideoGameModel>();
            videoGameList.Add(new VideoGameModel("World of Warcraft", "MMORPG", 60.00m, "Blizzard", "PC", new DateTime(2004, 11, 23)));
            videoGameList.Add(new VideoGameModel("Minecraft", "Survival Sandbox", 30.00m, "Mojang", "PC Xbox Playstation Switch", new DateTime(2011, 11, 18)));
            videoGameList.Add(new VideoGameModel("Runescape", "MMORPG", 0.00m, "Jagex", "PC", new DateTime(2001, 1, 4)));
            videoGameList.Add(new VideoGameModel("7 Days to Die", "Survival", 15.00m, "The Fun Pimps", "PC Xbox Playstation", new DateTime(2013, 12, 13)));
            videoGameList.Add(new VideoGameModel("Destiny 2", "First-person Shooter", 0.00m, "Bungie", "PC Xbox Playstation", new DateTime(2017, 09, 06)));
        }

        public List<VideoGameModel> AllVideoGames()
        {
            return videoGameList;
        }
    }
}
