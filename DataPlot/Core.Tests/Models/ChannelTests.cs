using Core.Models;
using System;
using Xunit;

namespace Core.Tests.Models
{
    public class ChannelTests
    {
        [Fact]
        public void Constructor_Beschriftung_null_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Channel(null, null));
        }
        [Fact]
        public void Constructor_Beschriftung_leer_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Channel(string.Empty, null));
        }
        [Fact]
        public void CanCreateInstance()
        {
            var channel = new Channel("Datum", typeof(DateTime));

            Assert.NotNull(channel);
            Assert.NotNull(channel.Beschriftung);
        }
    }
}
