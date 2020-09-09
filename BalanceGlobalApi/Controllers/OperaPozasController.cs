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
    public class OperaPozasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public OperaPozasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/OperaPozas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OperaPozas>>> GetOperaPozas()
        {
            return await _context.OperaPozas.ToListAsync();
        }

        // GET: api/OperaPozas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OperaPozas>> GetOperaPozas(int id)
        {
            var operaPozas = await _context.OperaPozas.FindAsync(id);

            if (operaPozas == null)
            {
                return NotFound();
            }

            return operaPozas;
        }

        // PUT: api/OperaPozas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOperaPozas(int id, OperaPozas operaPozas)
        {
            if (id != operaPozas.IdOperaPozas)
            {
                return BadRequest();
            }

            _context.Entry(operaPozas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperaPozasExists(id))
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

        // POST: api/OperaPozas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<OperaPozas>> PostOperaPozas(OperaPozas operaPozas)
        {
            _context.OperaPozas.Add(operaPozas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOperaPozas", new { id = operaPozas.IdOperaPozas }, operaPozas);
        }

        // DELETE: api/OperaPozas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OperaPozas>> DeleteOperaPozas(int id)
        {
            var operaPozas = await _context.OperaPozas.FindAsync(id);
            if (operaPozas == null)
            {
                return NotFound();
            }

            _context.OperaPozas.Remove(operaPozas);
            await _context.SaveChangesAsync();

            return operaPozas;
        }

        private bool OperaPozasExists(int id)
        {
            return _context.OperaPozas.Any(e => e.IdOperaPozas == id);
        }
    }
}
