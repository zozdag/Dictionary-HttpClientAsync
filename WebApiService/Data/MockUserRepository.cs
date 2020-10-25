using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiService.Models;

namespace WebApiService.Data
{
    public class MockUserRepository : IUserRepository<UserModel>
    {
        public UserModel Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(
                new UserModel { id = 1, Name = "Süreyya", SurName = "Temel", Job = "Engineer", Salary = 2343.99f });
            users.Add(
                new UserModel { id = 2, Name = "Cem", SurName = "Demir", Job = "Engineer", Salary = 5443.99f });
            users.Add(
                new UserModel { id = 3, Name = "Hasan", SurName = "Özaslan", Job = "Engineer", Salary = 8543.99f });

            return users;
        }

        public UserModel GetById([FromBody]UserModel id)
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(
                new UserModel { id = 1, Name = "Süreyya", SurName = "Temel", Job = "Engineer", Salary = 2343.99f });
            users.Add(
                new UserModel { id = 2, Name = "Cem", SurName = "Demir", Job = "Engineer", Salary = 5443.99f });
            users.Add(
                new UserModel { id = 3, Name = "Hasan", SurName = "Özaslan", Job = "Engineer", Salary = 8543.99f });
            var user = users.Where(x => x.id == id.id).FirstOrDefault();
            return user;
        }

        public UserModel Update()
        {
            throw new NotImplementedException();
        }
    }
}
