using System;

namespace VerbergenUndÜberschreiben
{
    public class Grafik
    {
        public string Farbe { get; set; }

        public virtual void Zeichnen()
        {
            Console.WriteLine($"Zeichne Grafik in der Farbe {Farbe}.");
        }
    }
}
