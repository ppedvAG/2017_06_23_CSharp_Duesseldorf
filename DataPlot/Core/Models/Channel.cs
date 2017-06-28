using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Models
{
    public class Channel : IEnumerable<string>
    {
        public Channel(string beschriftung, Type type)
        {
            if (string.IsNullOrWhiteSpace(beschriftung))
                throw new ArgumentNullException(nameof(beschriftung), $"{nameof(beschriftung)} must not be null.");

            Type = type;
            Beschriftung = beschriftung;
        }

        public Type Type { get; }
        public string Beschriftung { get; }
        private List<string> Werte { get; } = new List<string>();

        public void Add(string value)
        {
            Werte.Add(value);
        }

        public string this[int index]
        {
            get => Werte[index];
            set => Werte[index] = value;
        }

        public IEnumerator<string> GetEnumerator() => Werte.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Werte.GetEnumerator();
    }
}
