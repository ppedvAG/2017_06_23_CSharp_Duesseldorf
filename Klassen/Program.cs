using System;

namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Fahrzeug("Blau", 50);
            var pkw = new Fahrzeug("Rot");



            //f.geschwindigkeit = int.MaxValue;
            f.Geschwindigkeit = 50;
            Console.WriteLine(f.Geschwindigkeit);


            Console.WriteLine(f.Geschwindigkeit);
            Console.ReadKey();
        }
    }
}
