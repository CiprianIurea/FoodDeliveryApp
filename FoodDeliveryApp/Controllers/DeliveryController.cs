using Microsoft.AspNetCore.Mvc;
using FoodDeliveryApp.DataLayers;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using FoodDeliveryApp.DataLayers.Entities;

namespace FoodDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly FoodDeliveryAppDb _context;

        public DeliveryController(FoodDeliveryAppDb context)
        {
            _context = context;
        }

        // GET: api/delivery/livratori
        [HttpGet("livratori")]
        public async Task<IActionResult> GetAllLivratori()
        {
            var livratori = await _context.Livrator.ToListAsync();
            return Ok(livratori);
        }

        // GET: api/delivery/livratori/{id}
        [HttpGet("livratori/{id}")]
        public async Task<IActionResult> GetLivrator(int id)
        {
            var livrator = await _context.Livrator.FindAsync(id);
            if (livrator == null)
            {
                return NotFound();
            }
            return Ok(livrator);
        }

        // POST: api/delivery/livratori
        [HttpPost("livratori")]
        public async Task<IActionResult> AddLivrator([FromBody] Livrator livrator)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Livrator.Add(livrator);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetLivrator), new { id = livrator.LivratorId }, livrator);
        }

        // PUT: api/delivery/livratori/{id}
        [HttpPut("livratori/{id}")]
        public async Task<IActionResult> UpdateLivrator(int id, [FromBody] Livrator updatedLivrator)
        {
            if (id != updatedLivrator.LivratorId)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(updatedLivrator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LivratorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/delivery/livratori/{id}
        [HttpDelete("livratori/{id}")]
        public async Task<IActionResult> DeleteLivrator(int id)
        {
            var livrator = await _context.Livrator.FindAsync(id);
            if (livrator == null)
            {
                return NotFound();
            }

            _context.Livrator.Remove(livrator);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // GET: api/delivery/comenzi
        [HttpGet("comenzi")]
        public async Task<IActionResult> GetAllComenzi()
        {
            var comenzi = await _context.Comenzi.Include(c => c.livrator).ToListAsync();
            return Ok(comenzi);
        }

        // GET: api/delivery/comenzi/{id}
        [HttpGet("comenzi/{id}")]
        public async Task<IActionResult> GetComanda(int id)
        {
            var comanda = await _context.Comenzi.Include(c => c.livrator)
                                                .SingleOrDefaultAsync(c => c.ComandaId == id);
            if (comanda == null)
            {
                return NotFound();
            }
            return Ok(comanda);
        }

        private bool LivratorExists(int id)
        {
            return _context.Livrator.Any(e => e.LivratorId == id);
        }
    }
}
