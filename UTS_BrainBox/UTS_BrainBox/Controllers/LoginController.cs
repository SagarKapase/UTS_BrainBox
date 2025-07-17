using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UTS_BrainBox.Client.DBOperations;
using UTS_BrainBox.Client.Entities.Admin;
using UTS_BrainBox.Entities;

namespace UTS_BrainBox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private BBDbContext _context;
        public LoginController(BBDbContext context)
        {
            _context = context;
        }

        [HttpPost("auth")]
        public async Task<LoginResponse?> Login([FromBody] LoginRequestData loginRequest)
        {
            var user = await _context.AdministrationalDetails.FirstOrDefaultAsync(x => x.Email == loginRequest.Email && x.Password== loginRequest.Password);
            if (user == null)
                return null;

            return new LoginResponse
            {
                Email = user.Email,
                Password = user.Password,
                Role = user.Role
            };
        }
    }
}
