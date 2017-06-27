using System;

namespace AbstrakteKlassen
{
    public class Linie : Grafik
    {
        public int Länge { get; set; }

        public override void Zeichnen()
        {
            Console.WriteLine($"Zeichne Linie in der Farbe {Farbe} mit einer Länge von {Länge}.");
        }
    }
}
