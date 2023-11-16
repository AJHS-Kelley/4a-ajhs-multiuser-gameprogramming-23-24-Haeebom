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
   public static void Initialize(Player player)
        {
            player.Score = 0;
            computerscore = 0;          
        }

        public static void Board(Player player)
        {
            Console.WriteLine("Rock, Paper, Sciccors ... SHOOT!\n", player.playername, player.Score, computerscore);
        } 
          public static int ComputerRPS()
        {
            Random c = new Random();
            c_rps = c.Next(1, 4);

            return c_rps;
        }

        public static void Check(int c, Player player)
        {
            c = ComputerRPS();
             switch(c)
            {
                case 1:

                    if (p_rps == "R")
                    {
                        Console.WriteLine("Tie");
                    }
                    else if (p_rps == "P")
                    {
                        Console.WriteLine("Computer chose rock.\nPaper beats rock. {0} wins this round.", player.playername);
                        player.Score++;
                    }
                    else if (p_rps == "S")
                    {
                      Console.WriteLine("Computer chose rock.\nRock beats scissors.Computer wins this round.");
                        computerscore++;
                    }

                    break;

                case 2:

                    if (p_rps == "R")
                    {
                        Console.WriteLine("Computer chose paper.\nPaper beats rock. Computer wins this round.");
                        computerscore++;
                    }
                    else if (p_rps == "P")
                    {
                        Console.WriteLine("Tie");
                    }
                    else if (p_rps == "S")
                    {
                        Console.WriteLine("Computer chose paper.\nScissors beats rock. {0} wins this round.", player.playername);
                        player.Score++;
                    }

                    break;

                case 3:

                    if (p_rps == "R")
                    {
                        Console.WriteLine("Computer chose scissors.\nRock beats scissors. {0} wins this round.", player.playername);
                        player.Score++;
                    }
                    else if (p_rps == "P")
                    {
                        Console.WriteLine("Computer chose scissors.\nScissors beats paper. Computer wins this round.");
                        computerscore++;
                    }
                    else if (p_rps == "S")
                    {
                        Console.WriteLine("Tie");
                    }

                    break;

                    public static bool WhoWins(Player player)
                 {
                  if (player.Score == 5)
                 {
                   Console.WriteLine("\n{0} wins the game.\n",player.playername);
                   return true;
                 }
                 if (computerscore == 5)
                 {
                   Console.WriteLine("\nComputer wins the game.\n");
                   return true;
                  }

                   return false;
                 }
              }

                
                 
            }  
}   

                   
         
     