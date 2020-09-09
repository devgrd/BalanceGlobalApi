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
    public class CosechasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public CosechasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Cosechas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cosechas>>> GetCosechas()
        {
            return await _context.Cosechas.ToListAsync();
        }

        // GET: api/Cosechas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cosechas>> GetCosechas(int id)
        {
            var cosechas = await _context.Cosechas.FindAsync(id);

            if (cosechas == null)
            {
                return NotFound();
            }

            return cosechas;
        }

        // PUT: api/Cosechas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCosechas(int id, Cosechas cosechas)
        {
            if (id != cosechas.IdCosechas)
            {
                return BadRequest();
            }

            _context.Entry(cosechas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CosechasExists(id))
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

        // POST: api/Cosechas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cosechas>> PostCosechas(Cosechas cosechas)
        {
            _context.Cosechas.Add(cosechas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCosechas", new { id = cosechas.IdCosechas }, cosechas);
        }

        // DELETE: api/Cosechas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cosechas>> DeleteCosechas(int id)
        {
            var cosechas = await _context.Cosechas.FindAsync(id);
            if (cosechas == null)
            {
                return NotFound();
            }

            _context.Cosechas.Remove(cosechas);
            await _context.SaveChangesAsync();

            return cosechas;
        }

        private bool CosechasExists(int id)
        {
            return _context.Cosechas.Any(e => e.IdCosechas == id);
        }
    }
}
