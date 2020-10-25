using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiService.Models;

namespace WebApiService.Data
{
    public interface IUserRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(UserModel id);
        T Update();
        T Delete();
    }
}
