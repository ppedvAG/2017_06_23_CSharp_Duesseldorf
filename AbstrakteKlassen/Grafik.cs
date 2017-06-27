using System;

namespace AbstrakteKlassen
{
    public abstract class Grafik
    {
        public string Farbe { get; set; }

        public abstract void Zeichnen();
    }
}
