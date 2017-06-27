namespace Vererbung
{
    public class Pkw : Fahrzeug
    {
        public Pkw(string farbe) : base(farbe)
        { }

        public int Sitzplätze { get; set; }
    }
}
