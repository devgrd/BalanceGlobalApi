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
    public class OrigenesDatosController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public OrigenesDatosController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/OrigenesDatos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrigenesDatos>>> GetOrigenesDatos()
        {
            return await _context.OrigenesDatos.ToListAsync();
        }

        // GET: api/OrigenesDatos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrigenesDatos>> GetOrigenesDatos(int id)
        {
            var origenesDatos = await _context.OrigenesDatos.FindAsync(id);

            if (origenesDatos == null)
            {
                return NotFound();
            }

            return origenesDatos;
        }

        // PUT: api/OrigenesDatos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrigenesDatos(int id, OrigenesDatos origenesDatos)
        {
            if (id != origenesDatos.IdOrigenesDatos)
            {
                return BadRequest();
            }

            _context.Entry(origenesDatos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrigenesDatosExists(id))
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

        // POST: api/OrigenesDatos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<OrigenesDatos>> PostOrigenesDatos(OrigenesDatos origenesDatos)
        {
            _context.OrigenesDatos.Add(origenesDatos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrigenesDatos", new { id = origenesDatos.IdOrigenesDatos }, origenesDatos);
        }

        // DELETE: api/OrigenesDatos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrigenesDatos>> DeleteOrigenesDatos(int id)
        {
            var origenesDatos = await _context.OrigenesDatos.FindAsync(id);
            if (origenesDatos == null)
            {
                return NotFound();
            }

            _context.OrigenesDatos.Remove(origenesDatos);
            await _context.SaveChangesAsync();

            return origenesDatos;
        }

        private bool OrigenesDatosExists(int id)
        {
            return _context.OrigenesDatos.Any(e => e.IdOrigenesDatos == id);
        }
    }
}
