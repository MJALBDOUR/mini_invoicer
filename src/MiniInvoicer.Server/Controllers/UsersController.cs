﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniInvoicer.Client.Pages.Users;

namespace MiniInvoicer.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UsersController(UserManager<IdentityUser> userManager)
        {
            this._userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IdentityUser>>> GetUsers()
        {
            return await Task.FromResult(_userManager.Users.ToList());
        }

        [HttpPost]
        public async Task CreateUser(CreateUserModel userModel)
        {
            Console.WriteLine(userModel.Username);
        }
    }
}