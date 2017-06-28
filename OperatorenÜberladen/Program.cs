using System;

namespace OperatorenÜberladen
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Bruchzahl(30, 6);
            var b2 = new Bruchzahl(2, 3);

            Console.WriteLine(b1);
            Console.WriteLine(b2);

            var ergebnis = b1 * b2;

            Console.WriteLine(ergebnis);
            Console.ReadKey();
        }
    }
}
