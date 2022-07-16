using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DripchatBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public string Signup(string username, string password, string email=null)
        {
            return username + ' ' + password + ' ' + email;
        }

        [HttpPost]
        public string Login(string username, string password)
        {
            return username + ' ' + password;
        }
    }
}
