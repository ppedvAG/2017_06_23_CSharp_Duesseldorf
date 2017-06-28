namespace AbstrakteKlassen
{
    public abstract class Grafik
    {
        public string Farbe { get; set; }

        public abstract void Zeichnen();

        public void Rendern()
        {
            // wie auch immer das geht...
        }
    }
}
