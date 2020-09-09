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
    public class ReservoriosController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public ReservoriosController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Reservorios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reservorios>>> GetReservorios()
        {
            return await _context.Reservorios.ToListAsync();
        }

        // GET: api/Reservorios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reservorios>> GetReservorios(int id)
        {
            var reservorios = await _context.Reservorios.FindAsync(id);

            if (reservorios == null)
            {
                return NotFound();
            }

            return reservorios;
        }

        // PUT: api/Reservorios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservorios(int id, Reservorios reservorios)
        {
            if (id != reservorios.IdReservorios)
            {
                return BadRequest();
            }

            _context.Entry(reservorios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservoriosExists(id))
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

        // POST: api/Reservorios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Reservorios>> PostReservorios(Reservorios reservorios)
        {
            _context.Reservorios.Add(reservorios);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReservorios", new { id = reservorios.IdReservorios }, reservorios);
        }

        // DELETE: api/Reservorios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Reservorios>> DeleteReservorios(int id)
        {
            var reservorios = await _context.Reservorios.FindAsync(id);
            if (reservorios == null)
            {
                return NotFound();
            }

            _context.Reservorios.Remove(reservorios);
            await _context.SaveChangesAsync();

            return reservorios;
        }

        private bool ReservoriosExists(int id)
        {
            return _context.Reservorios.Any(e => e.IdReservorios == id);
        }
    }
}
