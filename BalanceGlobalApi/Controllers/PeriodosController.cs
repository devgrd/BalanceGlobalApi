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
    public class PeriodosController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public PeriodosController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Periodos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Periodos>>> GetPeriodos()
        {
            return await _context.Periodos.ToListAsync();
        }

        // GET: api/Periodos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Periodos>> GetPeriodos(int id)
        {
            var periodos = await _context.Periodos.FindAsync(id);

            if (periodos == null)
            {
                return NotFound();
            }

            return periodos;
        }

        // PUT: api/Periodos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeriodos(int id, Periodos periodos)
        {
            if (id != periodos.IdPeriodos)
            {
                return BadRequest();
            }

            _context.Entry(periodos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeriodosExists(id))
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

        // POST: api/Periodos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Periodos>> PostPeriodos(Periodos periodos)
        {
            _context.Periodos.Add(periodos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPeriodos", new { id = periodos.IdPeriodos }, periodos);
        }

        // DELETE: api/Periodos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Periodos>> DeletePeriodos(int id)
        {
            var periodos = await _context.Periodos.FindAsync(id);
            if (periodos == null)
            {
                return NotFound();
            }

            _context.Periodos.Remove(periodos);
            await _context.SaveChangesAsync();

            return periodos;
        }

        private bool PeriodosExists(int id)
        {
            return _context.Periodos.Any(e => e.IdPeriodos == id);
        }
    }
}
