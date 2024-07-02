using Microsoft.AspNetCore.Mvc;
using FoodDeliveryApp.DataLayers;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using FoodDeliveryApp.DataLayers.Entities;

namespace FoodDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly FoodDeliveryAppDb _context;

        public CartController(FoodDeliveryAppDb context)
        {
            _context = context;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddToCart(AdaugaCos puneInCos)
        {
            _context.Add(puneInCos);
            await _context.SaveChangesAsync();
            return Ok(puneInCos);
        }

        [HttpDelete("remove")]
        public async Task<IActionResult> RemoveFromCart(int userId, int productId, int cartId)
        {
            var item = await _context.Set<AdaugaCos>()
                .SingleOrDefaultAsync(p => p.UserId == userId && p.ProdusId == productId && p.CosId == cartId);
            if (item == null)
            {
                return NotFound();
            }
            _context.Remove(item);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetCart(int userId)
        {
            var cartItems = await _context.Set<AdaugaCos>()
                .Include(p => p.produs)
                .Where(p => p.UserId == userId)
                .ToListAsync();
            return Ok(cartItems);
        }
    }
}