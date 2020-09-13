using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaenasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public FaenasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Faenas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Faenas>>> GetFaenas()
        {
            return await _context.Faenas.ToListAsync();
        }

        // GET: api/Faenas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Faenas>> GetFaenas(int id)
        {
            var faenas = await _context.Faenas.FindAsync(id);

            if (faenas == null)
            {
                return NotFound();
            }

            return faenas;
        }

        // PUT: api/Faenas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaenas(int id, Faenas faenas)
        {
            if (id != faenas.IdFaenas)
            {
                return BadRequest();
            }

            _context.Entry(faenas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FaenasExists(id))
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

        // POST: api/Faenas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Faenas>> PostFaenas(Faenas faenas)
        {
            _context.Faenas.Add(faenas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFaenas", new { id = faenas.IdFaenas }, faenas);
        }

        // DELETE: api/Faenas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Faenas>> DeleteFaenas(int id)
        {
            var faenas = await _context.Faenas.FindAsync(id);
            if (faenas == null)
            {
                return NotFound();
            }

            _context.Faenas.Remove(faenas);
            await _context.SaveChangesAsync();

            return faenas;
        }

        private bool FaenasExists(int id)
        {
            return _context.Faenas.Any(e => e.IdFaenas == id);
        }
    }
}
