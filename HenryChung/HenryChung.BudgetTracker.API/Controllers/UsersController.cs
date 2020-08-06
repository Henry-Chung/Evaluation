using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HenryChung.BudgetTracker.Core.Entities;
using HenryChung.BudgetTracker.Core.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HenryChung.BudgetTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAllUsers()
        {
            var users = await _usersService.ListAllUsers();
            return Ok(users);
        }

        [HttpPost("add")]
        public async Task<ActionResult> AddUser([FromBody] Users user)
        {
            await _usersService.AddUser(user);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateUser([FromBody] Users user)
        {
            await _usersService.UpdateUser(user);
            return Ok();
        }

        [HttpPost("delete")]
        public async Task<ActionResult> DeleteUser([FromBody] Users user)
        {
            await _usersService.DeleteUser(user);
            return Ok();
        }


    }
}
