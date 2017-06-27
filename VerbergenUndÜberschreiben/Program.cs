using System;

namespace VerbergenUndÜberschreiben
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new Grafik { Farbe = "Rot" };
            var l = new Linie { Farbe = "Blau", Länge = 7 };
            var k = new Kreis { Farbe = "Grün", Radius = 2.12 };

            Console.ForegroundColor = ConsoleColor.DarkRed;
            g.Zeichnen();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            l.Zeichnen();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            k.Zeichnen();

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Black;
            MachWasMitEinerGrafik(g);
            MachWasMitEinerGrafik(l);
            MachWasMitEinerGrafik(k);

            Console.ReadKey();
        }

        private static void MachWasMitEinerGrafik(Grafik g)
        {
            g.Zeichnen();
        }
    }
}
