using System;
using System.Collections.Generic;
using System.Linq;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            //MeineMethode(8, 1.2, "hallo");

            //// Parameter benennen
            //MeineMethode(zahl: 9, wert: 2.2, s: "");
            //MeineMethode(wert: 2.2, s: "", zahl: 100);
            //MeineMethode(9, wert: 2.2, s: "");

            //OptionaleParameter(3.6, int.MaxValue, "°");
            //OptionaleParameter(3.6, int.MaxValue);
            //OptionaleParameter(3.6);

            //var values = new int[] { 2, 7, 9, 5, 3 };
            //var avg = Average(values);
            //int i = 2;
            //avg = Average(5, 6, 8, i, values[0], 5, 6, 0, 1, 8);

            //WertUndReferenztypen();
            //string s = "Mein Text";
            //ReferenzParameter(ref s);
            //Console.WriteLine(s);

            //OutParameter(out s);

            //Tuple<bool, int> result = new Tuple<bool, int>(false, 5);

            // Seit C#7
            (var jaNein, var zahl) = TuplesExample();
            var y = new List<(int Jahr, (string Ereingis, int Wiederholungen) Whatever)>();
            var x = (Jahr: 5, Whatever: (Ereignis: "Weihnachten", Wiederholungen:8));

            y.Add(x);
            y.Add((7, ("Haloween", 3)));

            foreach (var whatever in y)
            {
                Console.WriteLine($"{whatever.Whatever.Ereingis}");
            }

            Console.ReadKey();
        }

        private static string MeineMethode(int zahl, double wert, string s)
        {
            return zahl.ToString() + s;
        }
        private static void OptionaleParameter(double d, int zahl = 0, string s = "    ")
        {
            Console.WriteLine(zahl);
        }
        private static double Average(params int[] values)
        {
            var sum = (double)values.Sum();
            return sum / values.Length;
        }
        public static void WertUndReferenztypen()
        {
            int i = 5;
            ref int j = ref i;

            Console.WriteLine($"I: {i}");
            Console.WriteLine($"J: {j}");

            j = 100;
            Console.WriteLine("\nJ ändern:");
            Console.WriteLine($"I: {i}");
            Console.WriteLine($"J: {j}");

            Console.WriteLine("\n\n");
            Fahrzeug pkw = new Fahrzeug();
            pkw.geschwindigkeit = 50;
            var bus = pkw;

            Console.WriteLine($"PKW: {pkw.geschwindigkeit}");
            Console.WriteLine($"BUS: {bus.geschwindigkeit}");

            bus.geschwindigkeit = 200;
            Console.WriteLine($"\nBus ändern:");
            Console.WriteLine($"PKW: {pkw.geschwindigkeit}");
            Console.WriteLine($"BUS: {bus.geschwindigkeit}");
        }
        public static void ReferenzParameter(ref string text)
        {
            text += " mein Anhang";
        }
        public static void OutParameter(out string s)
        {
            s = "";

            int i;
            if(int.TryParse("5", out i))
            { }
        }
        public static (bool hatFunktioniert, int wert) TuplesExample()
        {
            return (true, 5);
        }
    }

    class Fahrzeug
    {
        public int geschwindigkeit;
    }
}
