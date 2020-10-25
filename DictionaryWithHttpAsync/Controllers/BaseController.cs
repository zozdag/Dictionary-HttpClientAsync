using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DictionaryWithHttpAsync.Repositories.Abstract;
using DictionaryWithHttpAsync.Repositories.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApiService.Models;

namespace DictionaryWithHttpAsync.Controllers
{
    public class BaseController : Controller
    {
        private readonly IHttpRepository<UserModel> _repository;
        public BaseController(IHttpRepository<UserModel> repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            
            return View(HttpRepository.UserkeyValuePairs);
        }
        public IActionResult TumKullanicilar()
        {
            HttpRepository.UserkeyValuePairs.Clear(); // Cache Temizleme
            HttpRepository.UserkeyValuePairs = _repository._GetAsync().Result;
            return RedirectToAction("Index");
        }

        public IActionResult KullaniciBul(string Name)
        {
            var user = _repository.PostDictionaryGetByName(Name);
            
            return View(user);
        }

       
    }
}
