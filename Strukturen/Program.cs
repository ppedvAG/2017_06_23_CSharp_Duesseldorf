namespace Strukturen
{
    class Program
    {
        // Objekte von Strukturen sind immer Werttypen
        // Keine Vererbung
        static void Main(string[] args)
        {
            var f = new Fahrzeug();
            f.Farbe = "Rot";
            f.Geschwindigkeit = 40;
            f.Beschleunigen(10);

            var pkw = f;
        }
    }
}
