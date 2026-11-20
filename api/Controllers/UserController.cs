using System;
using Microsoft.AspNetCore.Mvc;
using SafetyManagementSystem.Models; 

namespace SafetyManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 

    public class UserController : ControllerBase
    {
        [HttpGet] 

        public IActionResult GetUser()
        {
            var user = new UserModel
            {
                UserID = Guid.NewGuid(),
                UserName = "Timmy Trumpet",
                UserEmail = "timtrumpet@gmail.com",
                SystemRole = "IncidentCapturer"

            };
            return Ok(user);
        }
    }
}