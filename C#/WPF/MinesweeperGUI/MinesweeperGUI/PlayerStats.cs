using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace MinesweeperGUI
{
    class PlayerStats : IComparable<PlayerStats>
    {
        //Declare variables.
        public string name { get; set; }
        public string difficulty { get; set; }
        public int score { get; set; }

        //Create constructors.
        public PlayerStats()
        {

        }
        public PlayerStats(string name, string difficulty, int score)
        {
            this.name = name;
            this.difficulty = difficulty;
            this.score = score;
        }
        public int CompareTo(PlayerStats other)
        {
            //Sort by Name if time is the same
            if(this.score == other.score)
            {
                return this.name.CompareTo(other.name);
            }
            //Sort by the time to complete
            return other.score.CompareTo(this.score);
        }
    }
}
