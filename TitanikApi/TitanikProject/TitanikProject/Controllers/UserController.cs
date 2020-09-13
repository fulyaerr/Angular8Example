using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Titanik.Core;
using Titanik.Repository.Interfaces;
using Titanik.Service.Interfaces;
using Titanik.Service.Models;

namespace TitanikProject.Controllers
{
    public class UserController : BaseApiController
    {
        readonly IUser _userService;
        public UserController(IUser userService
           )
        {
            this._userService = userService;
        }

        [HttpPost]
        public void Post([FromBody] UserModel model)
        {
            _userService.Add(model);
        }
    }
}