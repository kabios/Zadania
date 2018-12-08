using System;

namespace Zad_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(checkDate(5, 1, 2020));

        }

        static bool checkDate(int day, int month, int year)
        {
            if (year < 2001 || year > 2099)
                return false;

            switch (month)
            {
                case 1:
                    if (day >= 0 && day <= 31)
                        return true;
                    break;
                case 2:
                    if (year % 4 == 0)
                    {
                        if (day >= 0 && day <= 29)
                            return true;
                    }
                    else
                    {
                        if (day >= 0 && day <= 28)
                            return true;
                    }
                    break;
                case 3:
                    if (day >= 0 && day <= 31)
                        return true;
                    break;
                case 4:
                    if (day >= 0 && day <= 30)
                        return true;
                    break;
                case 5:
                    if (day >= 0 && day <= 31)
                        return true;
                    break; ;
                case 6:
                    if (day >= 0 && day <= 30)
                        return true;
                    break;
                case 7:
                    if (day >= 0 && day <= 31)
                        return true;
                    break;
                case 8:
                    if (day >= 0 && day <= 31)
                        return true;
                    break;
                case 9:
                    if (day >= 0 && day <= 30)
                        return true;
                    break;
                case 10:
                    if (day >= 0 && day <= 31)
                        return true;
                    break;
                case 11:
                    if (day >= 0 && day <= 30)
                        return true;
                    break;
                case 12:
                    if (day >= 0 && day <= 31)
                        return true;
                    break;

            }

            return false;
        }
    }
}
