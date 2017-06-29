using Levante.Core;
using Levante.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Levante.Data.Web
{
    public class WebRepository : IRepository
    {
        private const string url = "https://jsonplaceholder.typicode.com/users";

        public IEnumerable<User> GetAll()
        {
            return GetData().Result;
        }

        private async Task<IEnumerable<User>> GetData()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<IEnumerable<User>>(json);
            }
            return null;
        }
    }
}
