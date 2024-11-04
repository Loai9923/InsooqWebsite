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
        [HttpGet]
        [Route("Get_All")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _users.GetAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("Search_For")]
        public async Task<IActionResult> Search(string Name)
        {
            var result = await _users.Search(Name);
            return Ok(result);
        }
    }

   
}
