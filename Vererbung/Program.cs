namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            var pkw = new Pkw("Grün");
            pkw.Geschwindigkeit = 30;
            pkw.Farbe = "Rot";
            pkw.Sitzplätze = 5;

            var f = new Fahrzeug("Weiß");
            var lkw = new Lkw("Schwarz");
            var c = new Cabrio("Lila");

            Lackieren(f);
            Lackieren(pkw);
            Lackieren(lkw);
            Lackieren(c);

            Fahrzeug fp = new Lkw("abc");
            Pkw x = (Pkw)fp;        // InvalidCastException
            Pkw y = fp as Pkw;      // y = null
        }

        private static void Lackieren(Fahrzeug f)
        {
            f.Farbe = "Gelb";
        }
    }
}
