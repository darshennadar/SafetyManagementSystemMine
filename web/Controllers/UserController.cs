using System; 
using Microsoft.AspNetCore.Mvc;
using SafetyManagementSystem.Models;

namespace SafetyManagementSystem.Web.Controllers
{
   public class UserController(HttpClient httpClient) : Controller
    {
        private readonly HttpClient _httpClient = httpClient;

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