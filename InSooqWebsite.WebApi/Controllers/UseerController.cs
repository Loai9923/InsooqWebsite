using inSooqWebsite.Services;
using InsooqWebsite.Domains.Dtos;
using InsooqWebsite.Domains.Enum;
using InsooqWebsite.Domains.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InSooqWebsite.WebApi.Controllers
{


    public class UseerController : Controller
    {
        private readonly IUser _users;
        public UseerController(IUser users)
        {
            _users = users;
        }

        [HttpPost]
        [Route ("Add-User")]
        public async Task<IActionResult> Add(UserDto user) 
        
        {
            var result = await _users.Add(user);
            return Ok("Added Successfully");
            
        }
    }
}
