using System;
using System.Linq;
using Xunit;

namespace Data.Common.Tests.Integration
{
    public class CsvReaderTests
    {
        [Fact]
        public void CanCreateInstance()
        {
            var reader = new CsvReader();
            Assert.NotNull(reader);
        }
        [Fact]
        public void GetAll_returns_correct_Extention()
        {
            var reader = new CsvReader();

            var channels = reader.GetAll(@"C:\Kurse\C# Grundlagen\2017_06_23_CSharp_Duesseldorf\DataPlot\Data.csv").ToList();

            Assert.Equal(6, channels.Count);

            Assert.Equal(3, channels[0].Count());
            Assert.Equal(3, channels[1].Count());
            Assert.Equal(3, channels[2].Count());
            Assert.Equal(3, channels[3].Count());
            Assert.Equal(3, channels[4].Count());
            Assert.Equal(3, channels[5].Count());

            Assert.Equal(typeof(DateTime), channels[0].Type);
            Assert.Equal(typeof(double), channels[1].Type);
            Assert.Equal(typeof(int), channels[2].Type);
            Assert.Equal(typeof(int), channels[3].Type);
            Assert.Equal(typeof(string), channels[4].Type);
            Assert.Equal(typeof(bool), channels[5].Type);
        }
    }
}
