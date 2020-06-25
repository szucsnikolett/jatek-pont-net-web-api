using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using jatek_pont_net.Domain.Models;
using jatek_pont_net.Persistence;

namespace jatek_pont_net.Domain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly jatek_pont_netContext _context;

        public TestController(jatek_pont_netContext context)
        {
            _context = context;
        }

        // GET: api/Test
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ar>>> GetAr()
        {
            return await _context.Ar.ToListAsync();
        }

        // GET: api/Test/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ar>> GetAr(int id)
        {
            var ar = await _context.Ar.FindAsync(id);

            if (ar == null)
            {
                return NotFound();
            }

            return ar;
        }

        // PUT: api/Test/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAr(int id, Ar ar)
        {
            if (id != ar.Id)
            {
                return BadRequest();
            }

            _context.Entry(ar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArExists(id))
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

        // POST: api/Test
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ar>> PostAr(Ar ar)
        {
            _context.Ar.Add(ar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAr", new { id = ar.Id }, ar);
        }

        // DELETE: api/Test/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ar>> DeleteAr(int id)
        {
            var ar = await _context.Ar.FindAsync(id);
            if (ar == null)
            {
                return NotFound();
            }

            _context.Ar.Remove(ar);
            await _context.SaveChangesAsync();

            return ar;
        }

        private bool ArExists(int id)
        {
            return _context.Ar.Any(e => e.Id == id);
        }
    }
}
