using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Job { get; set; }
        public float Salary { get; set; }
    }
}
