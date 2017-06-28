namespace OperatorenÜberladen
{
    public struct Bruchzahl
    {
        public int Zähler { get; }
        public int Nenner { get; }

        public Bruchzahl(int zähler, int nenner)
        {
            Zähler = zähler;
            Nenner = nenner;
        }
        
        public static Bruchzahl operator *(Bruchzahl left, Bruchzahl right)
        {
            return new Bruchzahl(
                zähler: left.Zähler * right.Zähler,
                nenner: left.Nenner * right.Nenner).Kürzen();
        }
        public static Bruchzahl operator *(Bruchzahl left, int right)
        {
            return new Bruchzahl(
                zähler: left.Zähler * right,
                nenner: left.Nenner).Kürzen();
        }
        public static Bruchzahl operator *(int left, Bruchzahl right)
        {
            return right * left;
        }
        public static bool operator ==(Bruchzahl left, Bruchzahl right)
        {
            return left.Zähler == right.Zähler &&
                   left.Nenner == right.Nenner;
        }
        public static bool operator !=(Bruchzahl left, Bruchzahl right)
        {
            return left.Zähler != right.Zähler ||
                   left.Nenner != right.Nenner;
        }

        public Bruchzahl Kürzen()
        {
            var größterGemeinsamerTeiler = GrößterGemeinsamerTeiler(Zähler, Nenner);

            return new Bruchzahl(
                zähler: Zähler / größterGemeinsamerTeiler,
                nenner: Nenner / größterGemeinsamerTeiler);

            int GrößterGemeinsamerTeiler(int z1, int z2)
            {
                if (z2 == 0)
                {
                    return z1;
                }
                else
                {
                    return GrößterGemeinsamerTeiler(z2, z1 % z2);
                }
            }
        }

        public override string ToString()
        {
            return $"{Zähler}/{Nenner}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Bruchzahl b)
                return this == b;

            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
