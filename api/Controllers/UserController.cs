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
                userID = Guid.NewGuid(),
                userName = "Timmy Trumpet",
                userEmail = "timtrumpet@gmail.com",
                systemRole = "IncidentCapturer"

            };
            return Ok(user);
        }
    }
}