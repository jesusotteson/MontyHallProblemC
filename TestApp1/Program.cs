using System;

namespace MontyHall
{
    class Program
    {
        public static bool montyHallProblem(int initiateChoice, int selection,
                             int car, int removeGoat)
        {
            bool win = false;
            int leftGoat = 0;
            int rightGoat = 2;
            switch (selection)
            {
                case 0: rightGoat = 2; leftGoat = 1; break;
                case 1: rightGoat = 2; leftGoat = 0; break;
                case 2: rightGoat = 1; leftGoat = 0; break;
            }

            int keepGoat = removeGoat == 0 ? rightGoat : leftGoat;

            if (initiateChoice == 0)
            {
                win = car == selection;
            }
            else
            {
                win = car != keepGoat;
            }
            return win;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int wins = 0;
            int losses = 0;

            for (int i = 0; i < 100000; i++)
            {
                int initiateChoice = 1;
                bool result = montyHallProblem(random.Next(3), initiateChoice, random.Next(3), random.Next(1));
                if (result)
                    wins++;
                else
                    losses++;
            }
            Console.WriteLine("Wins: {0}, Losses: {1}, Total: {2}", wins, losses, wins + losses);
            Console.ReadLine();
        }
    }
}