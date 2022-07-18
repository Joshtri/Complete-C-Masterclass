using System;

namespace ScorePlayers
{
    internal class Program
    {
        public static int highscore { get; set; }
        public static string HighscorePlayer = "Andreas";

        
        static void Main(string[] args)
        {

            ChecksHighScore("Anre", 324);


        }

        public static void ChecksHighScore(string PlayerName, int Score)
        {
            if (Score > highscore)
            {
                highscore = Score;
                HighscorePlayer = PlayerName;

                Console.WriteLine("New highscore holder is : {0}",Score);
                Console.WriteLine("It's now held by : {0}",PlayerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and " +
                    "is still held by "+ HighscorePlayer);
            }
        }
    }
}
