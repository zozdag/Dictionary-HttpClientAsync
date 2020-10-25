using DictionaryWithHttpAsync.Repositories.Abstract;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WebApiService.Models;

namespace DictionaryWithHttpAsync.Repositories.Concrete
{
    public class HttpRepository : IHttpRepository<UserModel>
    {
        public static Dictionary<int, UserModel> UserkeyValuePairs = 
            new Dictionary<int, UserModel>();

        private readonly HttpClient _client = new HttpClient();
        private string  URL;
        private HttpResponseMessage response;

        

        public async Task<Dictionary<int,UserModel>> _GetAsync()
        {
            URL = "http://localhost:52359/api/User/GetAll";
            response = await _client.GetAsync(URL);
            var result = JsonConvert.DeserializeObject<List<UserModel>>(
                await response.Content.ReadAsStringAsync());

            foreach(var user in result)
            {
                UserkeyValuePairs.Add(user.id,user);
            }
            return UserkeyValuePairs;

        }
        public IEnumerable<KeyValuePair<int,UserModel>> PostDictionaryGetByName(string _Name)
        {
            var c = new UserModel { Name = _Name };
            var user = UserkeyValuePairs.Where(x => x.Value.Name == _Name);
            return(user);

        }

        public async Task<UserModel> _PostAsync()
        {
            URL = "http://localhost:52359/api/User/GetById";
            var post = new UserModel { id = 1 };
            var content = JsonConvert.SerializeObject(post);

            response = await _client.PostAsync(URL, new StringContent(content, Encoding.UTF8, "application/json"));
            var result = await response.Content.ReadAsStringAsync();

            var sonuc = JsonConvert.DeserializeObject<UserModel>(result);
            return sonuc;

        }

    }
}
