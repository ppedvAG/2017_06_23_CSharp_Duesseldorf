using System;
using System.IO;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Bauteil();

            Lackieren(b);


            using (var fs = new Bauteil())
            {

            }
            


            Console.WriteLine(b.Farbe);
            Console.ReadKey();
        }

        private static void Lackieren(ILackierbar obj)
        {
            obj.Farbe = "Lila Blass Blau";
        }
    }
}
