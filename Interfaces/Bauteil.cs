using System;

namespace Interfaces
{
    public class Bauteil : ILackierbar, IDisposable
    {
        public int Id { get; set; }
        public string Material { get; set; }
        public string Farbe { get; set; }

        private bool isDisposed = false;
        public void Dispose()
        {
            Console.WriteLine("Bauteil wurde zerstört.");
            isDisposed = true;
        }
        ~Bauteil()
        {
            if (!isDisposed)
                Dispose();
        }
    }
}
