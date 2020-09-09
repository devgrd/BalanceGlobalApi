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
    public class PeriodosOperacionalesController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public PeriodosOperacionalesController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/PeriodosOperacionales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeriodosOperacionales>>> GetPeriodosOperacionales()
        {
            return await _context.PeriodosOperacionales.ToListAsync();
        }

        // GET: api/PeriodosOperacionales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PeriodosOperacionales>> GetPeriodosOperacionales(int id)
        {
            var periodosOperacionales = await _context.PeriodosOperacionales.FindAsync(id);

            if (periodosOperacionales == null)
            {
                return NotFound();
            }

            return periodosOperacionales;
        }

        // PUT: api/PeriodosOperacionales/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeriodosOperacionales(int id, PeriodosOperacionales periodosOperacionales)
        {
            if (id != periodosOperacionales.IdPeriodosOpercionales)
            {
                return BadRequest();
            }

            _context.Entry(periodosOperacionales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeriodosOperacionalesExists(id))
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

        // POST: api/PeriodosOperacionales
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PeriodosOperacionales>> PostPeriodosOperacionales(PeriodosOperacionales periodosOperacionales)
        {
            _context.PeriodosOperacionales.Add(periodosOperacionales);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPeriodosOperacionales", new { id = periodosOperacionales.IdPeriodosOpercionales }, periodosOperacionales);
        }

        // DELETE: api/PeriodosOperacionales/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PeriodosOperacionales>> DeletePeriodosOperacionales(int id)
        {
            var periodosOperacionales = await _context.PeriodosOperacionales.FindAsync(id);
            if (periodosOperacionales == null)
            {
                return NotFound();
            }

            _context.PeriodosOperacionales.Remove(periodosOperacionales);
            await _context.SaveChangesAsync();

            return periodosOperacionales;
        }

        private bool PeriodosOperacionalesExists(int id)
        {
            return _context.PeriodosOperacionales.Any(e => e.IdPeriodosOpercionales == id);
        }
    }
}
