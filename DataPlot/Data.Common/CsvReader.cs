using System;
using System.Collections.Generic;
using Core.Models;
using Data.Common.Interfaces;
using System.IO;
using System.Linq;

namespace Data.Common
{
    public class CsvReader : IReader
    {
        public IEnumerable<Channel> GetAll(string filePath)
        {
            List<Channel> channels;

            using (var fs = new FileStream(filePath, FileMode.Open))
            using (var sr = new StreamReader(fs))
            {
                var firstLine = sr.ReadLine();
                var secondLine = sr.ReadLine();

                channels = CreateChannels(firstLine, secondLine, ';').ToList();

                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var values = line.Split(';');

                    for (int i = 0; i < channels.Count; i++)
                    {
                        var value = values[i];
                        channels[i].Add(value);
                    }
                }
            }

            return channels;
        }

        private IEnumerable<Channel> CreateChannels(string firstLine, string secondLine, params char[] seperator)
        {
            var headers = firstLine.Split(seperator);
            var firstValues = secondLine.Split(seperator);

            if (headers.Length != firstValues.Length)
                throw new InvalidDataException($"Amount of Headers different to amount of Values in first row.");

            var channels = new List<Channel>();

            for (int i = 0; i < firstValues.Length; i++)
            {
                var value = firstValues[i];

                if (string.IsNullOrEmpty(headers[i]))
                    continue;

                Channel channel;

                if (bool.TryParse(value, out bool isChecked))
                    channel = new Channel(headers[i], typeof(bool));
                else if (int.TryParse(value, out int number))
                    channel = new Channel(headers[i], typeof(int));
                else if (double.TryParse(value, out double decimalnumber))
                    channel = new Channel(headers[i], typeof(double));
                else if (DateTime.TryParse(value, out DateTime date))
                    channel = new Channel(headers[i], typeof(DateTime));
                else
                    channel = new Channel(headers[i], typeof(string));

                channel.Add(value);
                channels.Add(channel);
            }

            return channels;
        }
    }
}
