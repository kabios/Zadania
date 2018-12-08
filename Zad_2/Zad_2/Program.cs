using System;

namespace Zad_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(checkDate(5, 1, 2020));
            Console.WriteLine(checkDate(29, 2, 2020));
            Console.WriteLine(checkDate(29, 2, 2001));
            Console.WriteLine(checkDate(30, 2, 2020));
            Console.WriteLine(checkDate(5, 1, 2000));
            Console.WriteLine(checkDate(5, 1, 2120));
            Console.WriteLine(checkDate(35, 1, 2090));


        }

        static bool checkDate(int day, int month, int year)
        {
            if (year < 2001 || year > 2099)
            {
                return false;
            }

            if (month < 1 || month > 12)
            {
                return false;
            }

            if (day < 1 || day > 31)
            {
                return false;
            }

            int monthDays = -1;

            switch (month)
            {
                case 1:
                    monthDays = 31;
                    break;
                case 2:
                    if (year % 4 == 0)
                    {
                        monthDays = 29;
                    }
                    else
                    {
                        monthDays = 28;
                    }
                    break;
                case 3:
                    monthDays = 31;
                    break;
                case 4:
                    monthDays = 30;
                    break;
                case 5:
                    monthDays = 31;
                    break;
                case 6:
                    monthDays = 30;
                    break;
                case 7:
                    monthDays = 31;
                    break;
                case 8:
                    monthDays = 31;
                    break;
                case 9:
                    monthDays = 30;
                    break; 
                case 10:
                    monthDays = 31;
                    break;
                case 11:
                    monthDays = 30;
                    break;
                case 12:
                    monthDays = 31;
                    break;
            }

            if (day <= monthDays)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
