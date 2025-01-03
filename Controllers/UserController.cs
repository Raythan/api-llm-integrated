using Microsoft.AspNetCore.Mvc;
using llm_integrated.Models;
using llm_integrated.Interfaces;
using System.Collections.Generic;

namespace llm_integrated.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost]
        public void Post([FromBody] User user)
        {
            _userService.AddUser(user);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            user.Id = id;
            _userService.UpdateUser(user);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.DeleteUser(id);
        }
    }
}