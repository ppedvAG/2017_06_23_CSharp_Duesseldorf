namespace Vererbung
{
    public class Fahrzeug
    {
        public Fahrzeug(string farbe)
        {
            Farbe = farbe;
        }

        public int Geschwindigkeit { get; set; }
        public string Farbe { get; set; }

        public void Beschleunigen(int dV) => Geschwindigkeit += dV;
    }
}
