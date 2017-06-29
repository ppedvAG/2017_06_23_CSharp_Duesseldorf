using System.Collections.Generic;
using Levante.Core;
using Levante.Core.Models;

namespace Levante.Data.Sample
{
    public class SampleRepository : IRepository
    {
        public IEnumerable<User> GetAll()
        {
            return new List<User>
            {
                new User { Id = 1, Name = "Hans", Email = "hans@email.de", Username = "hans2000", Address = new Address { City = "Düsseldorf", Street = "Königsallee", ZipCode = "12345" }},
                new User { Id = 2, Name = "Lisa", Email = "lisa@email.de", Username = "lisa2000", Address = new Address { City = "Düsseldorf", Street = "Königsallee", ZipCode = "12345" }},
                new User { Id = 3, Name = "Anna", Email = "anna@email.de", Username = "anna2000", Address = new Address { City = "Düsseldorf", Street = "Königsallee", ZipCode = "12345" }},
                new User { Id = 4, Name = "Sepp", Email = "sepp@email.de", Username = "sepp2000", Address = new Address { City = "Düsseldorf", Street = "Königsallee", ZipCode = "12345" }},
            };
        }
    }
}