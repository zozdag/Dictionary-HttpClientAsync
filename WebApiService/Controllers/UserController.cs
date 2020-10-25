using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiService.Data;
using WebApiService.Models;

namespace WebApiService.Controllers
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository<UserModel> _repository;

        public UserController(IUserRepository<UserModel> repository)
        {
            _repository = repository;
        }

        public ActionResult<IEnumerable<UserModel>> GetAll()
        {
            var user = _repository.GetAll();
            return Ok(user);
        }

        [HttpPost]
        public ActionResult<UserModel> GetById(UserModel id)
        {
            var user = _repository.GetById(id);
            return user;
        }

    }
}
