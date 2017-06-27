using System;

namespace HalloDelegates
{
    public delegate string MeinDelegate(int zahl, double wert);

    class Program
    {
        static void Main(string[] args)
        {
            MeinDelegate del = new MeinDelegate(MeineMethode);

            string ergebnis = del.Invoke(5, 7.9);

            Console.WriteLine(ergebnis);
            Console.ReadLine();
        }

        private static string MeineMethode(int i, double d)
        {
            return (i + d).ToString();
        }
    }
}
