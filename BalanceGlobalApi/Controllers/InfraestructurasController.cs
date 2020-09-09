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
    public class InfraestructurasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public InfraestructurasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Infraestructuras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Infraestructuras>>> GetInfraestructuras()
        {
            return await _context.Infraestructuras.ToListAsync();
        }

        // GET: api/Infraestructuras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Infraestructuras>> GetInfraestructuras(int id)
        {
            var infraestructuras = await _context.Infraestructuras.FindAsync(id);

            if (infraestructuras == null)
            {
                return NotFound();
            }

            return infraestructuras;
        }

        // PUT: api/Infraestructuras/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInfraestructuras(int id, Infraestructuras infraestructuras)
        {
            if (id != infraestructuras.IdInfraestructuras)
            {
                return BadRequest();
            }

            _context.Entry(infraestructuras).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfraestructurasExists(id))
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

        // POST: api/Infraestructuras
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Infraestructuras>> PostInfraestructuras(Infraestructuras infraestructuras)
        {
            _context.Infraestructuras.Add(infraestructuras);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInfraestructuras", new { id = infraestructuras.IdInfraestructuras }, infraestructuras);
        }

        // DELETE: api/Infraestructuras/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Infraestructuras>> DeleteInfraestructuras(int id)
        {
            var infraestructuras = await _context.Infraestructuras.FindAsync(id);
            if (infraestructuras == null)
            {
                return NotFound();
            }

            _context.Infraestructuras.Remove(infraestructuras);
            await _context.SaveChangesAsync();

            return infraestructuras;
        }

        private bool InfraestructurasExists(int id)
        {
            return _context.Infraestructuras.Any(e => e.IdInfraestructuras == id);
        }
    }
}
