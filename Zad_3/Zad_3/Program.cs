using System;

namespace Zad_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int firstPlayer = 0;
            int secendPlayer = 0;

            for(int i = 1; i <= 5; i++)
            {
                firstPlayer += round(i);
                secendPlayer += round(i);
            }

            Console.WriteLine("Punkty pierwszego gracza: " + firstPlayer);
            Console.WriteLine("Punkty drugiego gracza: " + secendPlayer);

            if (firstPlayer < secendPlayer)
                Console.WriteLine("Wygrywa gracz pierwszy.");
            else if (secendPlayer < firstPlayer)
                Console.WriteLine("Wygrywa gracz drugi");
            else
                Console.WriteLine("Remis");
        }

        static int round(int i)
        {
            int value, points = 0;
            for(int k = 0; k < 10; k++)
            {
                value = throwDice() + throwDice();

                if (k == 0)
                {
                    if (value == 7 || value == 11)
                    {
                        return points;
                    } else if (value == 2 || value == 12)
                    {
                        points = 120;
                        return points / i;
                    }
                }else if(value == 5)
                {
                    return points/i;
                }else
                {
                    points += value;
                }
            }
            return points/i;
        }

        static int throwDice()
        {
            Random x = new Random();
            return x.Next(1, 7);
        }
    }
}
