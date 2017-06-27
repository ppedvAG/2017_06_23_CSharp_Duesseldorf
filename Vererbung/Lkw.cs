namespace Vererbung
{
    public class Lkw : Fahrzeug
    {
        public Lkw(string farbe) : base(farbe)
        {
        }

        public int MaxLadung { get; set; }
    }
}
