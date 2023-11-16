// Naomi Williams, Example Game Methods, v0.1
using System;

namespace rockPaperScissors
{
    class Player
    {
        public string playername;
        private int playerscore;

        public int Score
        {
            get { return playerscore; }
            set { playerscore = value; }
        }
    }
    class RockPaperScissors
    {
        public static string p_rps;
        private static int c_rps;
        private static int computerscore;
    }
}
    