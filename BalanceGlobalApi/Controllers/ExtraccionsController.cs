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
    public class ExtraccionsController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public ExtraccionsController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Extraccions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Extraccion>>> GetExtraccion()
        {
            return await _context.Extraccion.ToListAsync();
        }

        // GET: api/Extraccions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Extraccion>> GetExtraccion(int id)
        {
            var extraccion = await _context.Extraccion.FindAsync(id);

            if (extraccion == null)
            {
                return NotFound();
            }

            return extraccion;
        }

        // PUT: api/Extraccions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExtraccion(int id, Extraccion extraccion)
        {
            if (id != extraccion.IdExtraccion)
            {
                return BadRequest();
            }

            _context.Entry(extraccion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtraccionExists(id))
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

        // POST: api/Extraccions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Extraccion>> PostExtraccion(Extraccion extraccion)
        {
            _context.Extraccion.Add(extraccion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExtraccion", new { id = extraccion.IdExtraccion }, extraccion);
        }

        // DELETE: api/Extraccions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Extraccion>> DeleteExtraccion(int id)
        {
            var extraccion = await _context.Extraccion.FindAsync(id);
            if (extraccion == null)
            {
                return NotFound();
            }

            _context.Extraccion.Remove(extraccion);
            await _context.SaveChangesAsync();

            return extraccion;
        }

        private bool ExtraccionExists(int id)
        {
            return _context.Extraccion.Any(e => e.IdExtraccion == id);
        }
    }
}
