using System;

namespace Zad_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double firstPlayer = 0;
            double secendPlayer = 0;

            for (int roundNumber = 1; roundNumber <= 5; roundNumber++)
            {
                firstPlayer += round();
                secendPlayer += round();
            }

            Console.WriteLine("Punkty pierwszego gracza: " + firstPlayer);
            Console.WriteLine("Punkty drugiego gracza: " + secendPlayer);

            if (firstPlayer < secendPlayer)
            {
                Console.WriteLine("Wygrywa gracz pierwszy.");
            }
            else if (secendPlayer < firstPlayer)
            {
                Console.WriteLine("Wygrywa gracz drugi");
            }
            else
            {
                Console.WriteLine("Remis");
            }
        }

        static double round()
        {
            double value, points = 0;
            for (int rollNumber = 1; rollNumber <= 10; rollNumber++)
            {
                value = rollDice() + rollDice();

                if (rollNumber == 1)
                {
                    if (value == 7 || value == 11 || value == 5)
                    {
                        return 0;
                    }
                    else if (value == 2 || value == 12)
                    {
                        points += 10;
                        for (int roll = 2; roll <= 10; roll++)
                        {
                            points += 12 / roll;
                        }
                        break;
                    }
                }

                if (value == 5)
                {
                    break;
                }
                else
                {
                    points += value / rollNumber;
                }
            }

            points = Math.Floor(points);
            return points;
        }

        static int rollDice()
        {
            Random x = new Random();
            return x.Next(1, 7);
        }
    }
}
