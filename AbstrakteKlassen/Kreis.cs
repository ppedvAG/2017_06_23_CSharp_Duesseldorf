using System;

namespace AbstrakteKlassen
{
    public class Kreis : Grafik
    {
        public double Radius { get; set; }

        public override void Zeichnen()
        {
            Console.WriteLine($"Zeichne Kreis in der Farbe {Farbe} mit einem Radius von {Radius}.");
        }
    }
}
