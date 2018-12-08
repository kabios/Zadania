using System;

namespace Zad_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(checkEan("0323456123221", 2));
        }

        static string checkEan(string barcode, int type)
        {
            int lengthBarcode = barcode.Length;

            for (int i = 0; i < lengthBarcode; i++)
            {
                if (Char.IsNumber(barcode[i]) == false)
                {
                    return "Niepoprawny EAN";
                }
            }

            if (type == 1)
            {
                if(barcode[0]=='0' && lengthBarcode == 7 || lengthBarcode == 9 || lengthBarcode == 12)
                {
                    barcode = "0" + barcode;
                    lengthBarcode = barcode.Length;
                }

                if (lengthBarcode == 8)
                {
                    return barcode;
                }
                else if (lengthBarcode == 10)
                {
                    barcode = barcode.Remove(8, 2);
                }
                else if (lengthBarcode == 13)
                {
                    barcode = barcode.Remove(8, 5);
                }
                else
                {
                    return "Niepoprawny EAN";
                }

            }
            else if (type == 2)
            {
                if (barcode[0] == '0' && lengthBarcode == 12 || lengthBarcode == 14 || lengthBarcode == 17)
                {
                    barcode = "0" + barcode;
                    lengthBarcode = barcode.Length;
                }

                if (lengthBarcode == 13)
                {
                    return barcode;
                }
                else if (lengthBarcode == 15)
                {
                    barcode = barcode.Remove(13, 2);
                }
                else if (lengthBarcode == 18)
                {
                    barcode = barcode.Remove(13, 5);
                }
                else
                {
                    return "Niepoprawny EAN";
                }
            }
            else
            {
                return "Niepoprawny typ EAN";
            }

            return barcode;
        }
    }
}

