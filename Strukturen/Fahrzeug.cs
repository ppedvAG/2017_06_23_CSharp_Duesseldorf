using System;

namespace Strukturen
{
    public struct Fahrzeug : IDisposable
    {
        public int Geschwindigkeit { get; set; }
        public string Farbe { get; set; }

        public void Beschleunigen(int dV) => Geschwindigkeit += dV;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
