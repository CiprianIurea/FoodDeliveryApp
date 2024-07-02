using Microsoft.AspNetCore.Mvc;
using FoodDeliveryApp.DataLayers;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodDeliveryApp.DataLayers.Entities;

namespace FoodDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly FoodDeliveryAppDb _context;

        public ProfileController(FoodDeliveryAppDb context)
        {
            _context = context;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetProfile(int userId)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.UserId == userId);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateProfile(int userId, User updatedUser)
        {
            var user = await _context.Users.SingleOrDefaultAsync(u => u.UserId == userId);
            if (user == null)
            {
                return NotFound();
            }
            user.Nume = updatedUser.Nume;
            user.Email = updatedUser.Email;
            user.Telefon = updatedUser.Telefon;
            user.Adresa = updatedUser.Adresa;
            await _context.SaveChangesAsync();
            return Ok(user);
        }
    }
}