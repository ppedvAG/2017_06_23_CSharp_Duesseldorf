using Levante.Core;
using Levante.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Levante.Data.Files
{
    public class FileRepository : IRepository
    {
        public IEnumerable<User> GetAll()
        {
            var json = File.ReadAllText("Data.json");
            return JsonConvert.DeserializeObject<IEnumerable<User>>(json);
        }
    }
}
