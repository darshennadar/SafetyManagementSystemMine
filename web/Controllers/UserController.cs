using System; 
using Microsoft.AspNetCore.Mvc;
using SafetyManagementSystem.Web.Models;


namespace SafetyManagementSystem.Web.Controllers
{
   public class UserController : Controller
    {
        private readonly HttpClient _httpClient; 
        
        public UserController(HttpClient httpClient)
        {

            _httpClient = httpClient; 
            
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var response = await _httpClient.GetAsync("api/User");
            
            if (response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode);
        
            }
             var user = await response.Content.ReadFromJsonAsync<UserModel>(); 
             
             return View(user);
        }
    }
}