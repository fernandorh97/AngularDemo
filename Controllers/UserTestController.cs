using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo_app.db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace demo_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserTestController : ControllerBase
    {
        // private static readonly string Prueba = "mmPRUEBA";

        private readonly ILogger<UserTestController> _logger;
        private readonly IUserService _userService;

        public UserTestController(ILogger<UserTestController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet("{value}")]
        public User GetById(int value)
        {
            return _userService.GetUser(value);
        }

        [HttpGet("all")]
        public IEnumerable<User> GetAll()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet("count")]
        public int UserCount()
        {
            return _userService.GetUserCount();
        }

        [HttpPost("add")]
        public void AddUser(User user)
        {
            // Console.WriteLine($"Add User: {user.UserId} {user.Email} {user.Password}");
            _userService.AddUser(user);
            // Console.WriteLine($"User: {user.UserId} {user.Email} {user.Password}");
        }
    }
}
