using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using WebApiService.Models;

namespace DictionaryWithHttpAsync.Repositories.Abstract
{
    public interface IHttpRepository<T> 
    {
        Task<Dictionary<int,T>> _GetAsync();
        Task<T> _PostAsync();
        IEnumerable<KeyValuePair<int,UserModel>> PostDictionaryGetByName(string Name);

        

    }
}
