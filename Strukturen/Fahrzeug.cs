namespace Strukturen
{
    public struct Fahrzeug
    {
        public int Geschwindigkeit { get; set; }
        public string Farbe { get; set; }

        public void Beschleunigen(int dV) => Geschwindigkeit += dV;
    }
}
