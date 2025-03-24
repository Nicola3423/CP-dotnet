using Microsoft.AspNetCore.Mvc;
using Sessions_app.Model;
using Microsoft.EntityFrameworkCore; 
using System.Diagnostics;

namespace Sessions_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrinquedosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BrinquedosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/brinquedos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brinquedo>>> GetBrinquedos()
        {
            return await _context.Brinquedos.ToListAsync();
        }

        // GET: api/brinquedos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Brinquedo>> GetBrinquedo(int id)
        {
            var brinquedo = await _context.Brinquedos.FindAsync(id);

            if (brinquedo == null)
            {
                return NotFound();
            }

            return brinquedo;
        }

        // POST: api/brinquedos
        [HttpPost]
        public async Task<ActionResult<Brinquedo>> PostBrinquedo(Brinquedo brinquedo)
        {
            _context.Brinquedos.Add(brinquedo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBrinquedo", new { id = brinquedo.Id_brinquedo }, brinquedo);
        }

        // PUT: api/brinquedos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrinquedo(int id, Brinquedo brinquedo)
        {
            if (id != brinquedo.Id_brinquedo)
            {
                return BadRequest("ID do brinquedo não coincide com a URL");
            }

            _context.Entry(brinquedo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrinquedoExists(id))
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

        // DELETE: api/brinquedos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrinquedo(int id)
        {
            var brinquedo = await _context.Brinquedos.FindAsync(id);
            if (brinquedo == null)
            {
                return NotFound();
            }

            _context.Brinquedos.Remove(brinquedo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BrinquedoExists(int id)
        {
            return _context.Brinquedos.Any(e => e.Id_brinquedo == id);
        }
    }
}

