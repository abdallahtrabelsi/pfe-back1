using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pfe.Models;

namespace pfe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayeursController : ControllerBase
    {
        private readonly GestContext _context;

        public PayeursController(GestContext context)
        {
            _context = context;
        }

        // GET: api/Payeurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payeur>>> GetPayeurs()
        {
            return await _context.Payeurs.ToListAsync();
        }

        // GET: api/Payeurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Payeur>> GetPayeur(int id)
        {
            var payeur = await _context.Payeurs.FindAsync(id);

            if (payeur == null)
            {
                return NotFound();
            }

            return payeur;
        }

        // PUT: api/Payeurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayeur(int id, Payeur payeur)
        {
            if (id != payeur.PayeurId)
            {
                return BadRequest();
            }

            _context.Entry(payeur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PayeurExists(id))
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

        // POST: api/Payeurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Payeur>> PostPayeur(Payeur payeur)
        {
            _context.Payeurs.Add(payeur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPayeur", new { id = payeur.PayeurId }, payeur);
        }

        // DELETE: api/Payeurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayeur(int id)
        {
            var payeur = await _context.Payeurs.FindAsync(id);
            if (payeur == null)
            {
                return NotFound();
            }

            _context.Payeurs.Remove(payeur);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PayeurExists(int id)
        {
            return _context.Payeurs.Any(e => e.PayeurId == id);
        }
    }
}
