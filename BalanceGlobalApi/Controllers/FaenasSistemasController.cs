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
    public class FaenasSistemasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public FaenasSistemasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/FaenasSistemas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FaenasSistemas>>> GetFaenasSistemas()
        {
            return await _context.FaenasSistemas.ToListAsync();
        }

        // GET: api/FaenasSistemas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FaenasSistemas>> GetFaenasSistemas(int id)
        {
            var faenasSistemas = await _context.FaenasSistemas.FindAsync(id);

            if (faenasSistemas == null)
            {
                return NotFound();
            }

            return faenasSistemas;
        }

        // PUT: api/FaenasSistemas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaenasSistemas(int id, FaenasSistemas faenasSistemas)
        {
            if (id != faenasSistemas.IdFaenasSistemas)
            {
                return BadRequest();
            }

            _context.Entry(faenasSistemas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FaenasSistemasExists(id))
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

        // POST: api/FaenasSistemas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FaenasSistemas>> PostFaenasSistemas(FaenasSistemas faenasSistemas)
        {
            _context.FaenasSistemas.Add(faenasSistemas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFaenasSistemas", new { id = faenasSistemas.IdFaenasSistemas }, faenasSistemas);
        }

        // DELETE: api/FaenasSistemas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FaenasSistemas>> DeleteFaenasSistemas(int id)
        {
            var faenasSistemas = await _context.FaenasSistemas.FindAsync(id);
            if (faenasSistemas == null)
            {
                return NotFound();
            }

            _context.FaenasSistemas.Remove(faenasSistemas);
            await _context.SaveChangesAsync();

            return faenasSistemas;
        }

        private bool FaenasSistemasExists(int id)
        {
            return _context.FaenasSistemas.Any(e => e.IdFaenasSistemas == id);
        }
    }
}
