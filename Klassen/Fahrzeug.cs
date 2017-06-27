namespace Klassen
{
    public class Fahrzeug
    {
        private int _geschwindigkeit;
        public int Geschwindigkeit
        {
            get
            {
                return _geschwindigkeit;
            }
            set
            {
                if (value > 200)
                    value = 200;

                _geschwindigkeit = value;
            }
        }

        private string _farbe;
        // Ab C#7
        public string Farbe
        {
            get => _farbe;
            set => _farbe = value;
        }

        // Auto Properties
        public int Baujahr { get; set; }

        public string Typnummer { get; }

        public Fahrzeug(string farbe)
        {
            Farbe = farbe;
            Typnummer = "ABC123";
        }
        public Fahrzeug(string farbe, int geschwindigkeit)
            : this(farbe)
        {
            Geschwindigkeit = geschwindigkeit;
        }
        public Fahrzeug(string farbe, int geschwindigkeit, int baujahr)
            :this(farbe, geschwindigkeit)
        {
            Baujahr = baujahr;
        }


        #region Datenkapselung in Java
        //public int GetGeschwindigkeit()
        //{
        //    return _geschwindigkeit;
        //}
        //public void SetGeschwindigkeit(int geschwindigkeit)
        //{
        //    if (geschwindigkeit > 200)
        //        geschwindigkeit = 200;

        //    _geschwindigkeit = geschwindigkeit;
        //}
        #endregion

        // Ab C#6
        public void Beschleunigen(int dV) => Geschwindigkeit += dV;
        public void Beschleunigen(double faktor)
        {
            Geschwindigkeit = (int)(Geschwindigkeit * faktor);
        }
        public void Beschleunigen(float faktor)
        {
            Geschwindigkeit = (int)(Geschwindigkeit * faktor);
        }
        public void Beschleunigen(int abc, int def) { }
        public void Beschleunigen(double abc, int def) { }
        public void Beschleunigen(int Hallo, double abc) { }

        public void Bremsen(int dV) => Geschwindigkeit -= dV;

        ~Fahrzeug()
        {

        }
    }
}
