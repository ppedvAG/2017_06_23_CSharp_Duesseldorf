using System;

namespace HalloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt!");

            string text = "Mein wichtiger Text";
            var andererText = "laksdjfölaksjf";

            byte einByte = 255;
            short s = 32000;
            int x = 5;
            long l = 90000000000000;

            float f = 7.98f;
            double d = 2.12;
            decimal dec = 7.34m;

            char c = '\'';

            bool b = true;      // false

            /*
             
             Ein langes Kommentar
             
             */


            // Mathematische Operatoren
            x = 8 + 9;
            x = 8 - 9;
            x = 8 * 9;
            x = 13 / 5;
            x = 13 % 5;

            // Vergleichsoperatoren
            b = 7 < 4;
            b = 7 <= 4;
            b = 7 > 4;
            b = 7 >= 4;
            b = 7 == 4;
            b = 7 != 4;
            b = !(5 < 3);

            // Verknüpfungsoperatoren
            b = (6 < 7) & (4 > 4);
            b = (6 < 7) | (4 > 4);
            b = (6 < 7) ^ (4 > 4);

            b = (6 < 7) && (4 > 4);
            b = (6 < 7) || (4 > 4);


            var eingabe = Console.ReadLine();

            x = Convert.ToInt32(eingabe);
            x = int.Parse(eingabe, System.Globalization.NumberStyles.HexNumber, new System.Globalization.CultureInfo("de-DE"));

            Console.ReadKey();
        }
    }
}
