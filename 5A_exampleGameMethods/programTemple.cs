// Naomi Williams, Example Game Methods, v0.1
using System;

namespace rockpaperscissors
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
                        Console.WriteLine("Computer chose rock.\nRock beats scissors. Computer wins this round.");
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
            }
        }

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
    class Program
    {
        public static bool play;
        public static string startgame;

        static void StartGameOrNot()
        {
            do
            {                
                startgame = Console.ReadLine().ToUpper();
                startgame.ToUpper();

                if (startgame == "Y")
                {
                    play = true;
                }
                else if (startgame == "N")
                {
                    Console.WriteLine("\nOkay then, goodbye");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Write("\nInvalid. Do you want to start the game? [Y/N] --> ");
                }
            } while (startgame != "Y" && startgame != "N");
        }
        static void Main(string[] args)
        {
            Console.Write("Do you want to start the game? [Y/N] --> ");
            StartGameOrNot();

            Player player1 = new Player();

            Console.Clear();
            Console.Write("\n\n\tWhat is your name? --> ");
            player1.playername = Console.ReadLine();

            Console.Clear();
            RockPaperScissors.Initialize(player1);

            while (play)
            {                              
                RockPaperScissors.Board(player1);

                do
                {
                    Console.Write("Rock, paper, scissors? [R/P/S] --> ");
                    RockPaperScissors.p_rps = Console.ReadLine().ToUpper();                  
                } while (RockPaperScissors.p_rps == "R" && RockPaperScissors.p_rps == "P" && RockPaperScissors.p_rps == "S");

                int c = RockPaperScissors.ComputerRPS();

                Console.Clear();

                RockPaperScissors.Check(c, player1);

                if(RockPaperScissors.WhoWins(player1))
                {
                    Console.Write("Replay? --> ");
                    StartGameOrNot();
                    RockPaperScissors.Initialize(player1);
                    Console.Clear();
                }
            }
        }
    }
}