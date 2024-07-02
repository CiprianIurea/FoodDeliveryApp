using Microsoft.AspNetCore.Mvc;
using FoodDeliveryApp.DataLayers;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly FoodDeliveryAppDb _context;

        public RestaurantController(FoodDeliveryAppDb context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRestaurants()
        {
            var restaurants = await _context.Restaurante.ToListAsync();
            return Ok(restaurants);
        }

        [HttpGet("{id}/menu")]
        public async Task<IActionResult> GetRestaurantMenu(int id)
        {
            var restaurant = await _context.Restaurante.Include(r => r.produse)
                .SingleOrDefaultAsync(r => r.RestaurantId == id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return Ok(restaurant.produse);
        }
    }
}