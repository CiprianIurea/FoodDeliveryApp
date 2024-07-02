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
    public class OrderController : ControllerBase
    {
        private readonly FoodDeliveryAppDb _context;

        public OrderController(FoodDeliveryAppDb context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PlaceOrder(Comanda comanda)
        {
            _context.Comenzi.Add(comanda);
            await _context.SaveChangesAsync();
            return Ok(comanda);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetOrdersHistory(int userId)
        {
            var orders = await _context.Comenzi
                .Include(o => o.cos)
                .Include(o => o.livrator)
                .Where(o => o.cos._adaugaCos.Any(pc => pc.UserId == userId))
                .ToListAsync();
            return Ok(orders);
        }

        [HttpPost("{orderId}/cancel")]
        public async Task<IActionResult> CancelOrder(int orderId)
        {
            var order = await _context.Comenzi.SingleOrDefaultAsync(o => o.ComandaId == orderId);
            if (order == null)
            {
                return NotFound();
            }
            // Update order status to Cancelled
            await _context.SaveChangesAsync();
            return Ok(order);
        }

        [HttpPost("{orderId}/reinitiate")]
        public async Task<IActionResult> ReinitiateOrder(int orderId)
        {
            var order = await _context.Comenzi
                .Include(o => o.cos)
                .ThenInclude(c => c._adaugaCos)
                .SingleOrDefaultAsync(o => o.ComandaId == orderId);

            if (order == null)
            {
                return NotFound();
            }

            var newOrder = new Comanda
            {
                CosId = order.CosId,
                LivratorId = order.LivratorId,
                cos = order.cos
            };

            _context.Comenzi.Add(newOrder);
            await _context.SaveChangesAsync();
            return Ok(newOrder);
        }

        [HttpPost("{orderId}/tip")]
        public async Task<IActionResult> GiveTip(int orderId, [FromBody] float tipAmount)
        {
            var order = await _context.Comenzi
                .Include(o => o.livrator)
                .SingleOrDefaultAsync(o => o.ComandaId == orderId);

            if (order == null)
            {
                return NotFound();
            }

            // Implement the logic to handle the tip, e.g., update courier's earnings or simply log it
            Console.WriteLine($"User gave a tip of {tipAmount} to courier {order.livrator.Nume}");

            return Ok();
        }


    }
}