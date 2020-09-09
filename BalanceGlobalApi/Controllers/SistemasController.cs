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
    public class SistemasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public SistemasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Sistemas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sistemas>>> GetSistemas()
        {
            return await _context.Sistemas.ToListAsync();
        }

        // GET: api/Sistemas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sistemas>> GetSistemas(int id)
        {
            var sistemas = await _context.Sistemas.FindAsync(id);

            if (sistemas == null)
            {
                return NotFound();
            }

            return sistemas;
        }

        // PUT: api/Sistemas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSistemas(int id, Sistemas sistemas)
        {
            if (id != sistemas.IdSistemas)
            {
                return BadRequest();
            }

            _context.Entry(sistemas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SistemasExists(id))
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

        // POST: api/Sistemas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Sistemas>> PostSistemas(Sistemas sistemas)
        {
            _context.Sistemas.Add(sistemas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSistemas", new { id = sistemas.IdSistemas }, sistemas);
        }

        // DELETE: api/Sistemas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Sistemas>> DeleteSistemas(int id)
        {
            var sistemas = await _context.Sistemas.FindAsync(id);
            if (sistemas == null)
            {
                return NotFound();
            }

            _context.Sistemas.Remove(sistemas);
            await _context.SaveChangesAsync();

            return sistemas;
        }

        private bool SistemasExists(int id)
        {
            return _context.Sistemas.Any(e => e.IdSistemas == id);
        }
    }
}
