using System;
using System.Threading.Tasks;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            var eingabe = int.Parse(Console.ReadLine());

            object x = 6;

            #region If Else

            //if (eingabe > 7)
            //{
            //    Console.WriteLine("Größer Sieben");
            //}
            //else if(eingabe < 7)
            //{
            //    Console.WriteLine("Whatever..");
            //}
            //else
            //{
            //    Console.WriteLine("nicht Größer Sieben");
            //}

            //if (x is int)
            //{
            //    int i = (int)x;
            //    i++;
            //    Console.WriteLine(i);
            //}
            //// ab C#7
            //if (x is int j)
            //{
            //    j++;
            //    Console.WriteLine(j);
            //}

            #endregion
            #region Switch

            //switch (eingabe)
            //{
            //    case 5:
            //        Console.WriteLine("Fünf");
            //        break;

            //    case 6:     // Fallthrough
            //    case 7:
            //        Console.WriteLine("Sechs oder Sieben");
            //        break;

            //    default:
            //        break;
            //}

            //// ab C#7
            //switch (x)
            //{
            //    case int i when i == 5:
            //        Console.WriteLine("Es war integer");
            //        break;

            //    case int i:
            //        Console.WriteLine("Es war integer");
            //        break;

            //    case string s when s.Length > 5:
            //        Console.WriteLine("Es war ein string Länge > 5");
            //        break;

            //    case string s:
            //        Console.WriteLine("Es war string");
            //        break;

            //    default:
            //        break;
            //}

            #endregion

            #region While Schleife

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i++);
            //}

            #endregion
            #region Do-While Schleife

            //int i = 400;
            //do
            //{
            //    Console.WriteLine(i++);
            //}
            //while (i < 10);

            #endregion
            #region For Schleife

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 10 - 1; i >= 0; i--)
            //    if(i == 5)
            //        Console.WriteLine(i);


            #endregion
            #region Foreach Schleife

            var meinText = "Mein wichtiger Text";

            foreach (var textZeichen in meinText)
            {
                Console.WriteLine(textZeichen);
            }

            #endregion

            Console.ReadLine();
        }
    }
}
