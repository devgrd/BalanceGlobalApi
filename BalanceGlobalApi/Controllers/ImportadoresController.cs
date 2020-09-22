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
    public class ImportadoresController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public ImportadoresController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Importadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Importadores>>> GetImportadores()
        {
            return await _context.Importadores.ToListAsync();
        }

        // GET: api/Importadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Importadores>> GetImportadores(int id)
        {
            var importadores = await _context.Importadores.FindAsync(id);

            if (importadores == null)
            {
                return NotFound();
            }

            return importadores;
        }

        // PUT: api/Importadores/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImportadores(int id, Importadores importadores)
        {
            if (id != importadores.IdImportadores)
            {
                return BadRequest();
            }

            _context.Entry(importadores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImportadoresExists(id))
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

        // POST: api/Importadores
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Importadores>> PostImportadores(Importadores importadores)
        {
            _context.Importadores.Add(importadores);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImportadores", new { id = importadores.IdImportadores }, importadores);
        }

        // DELETE: api/Importadores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Importadores>> DeleteImportadores(int id)
        {
            var importadores = await _context.Importadores.FindAsync(id);
            if (importadores == null)
            {
                return NotFound();
            }

            _context.Importadores.Remove(importadores);
            await _context.SaveChangesAsync();

            return importadores;
        }

        private bool ImportadoresExists(int id)
        {
            return _context.Importadores.Any(e => e.IdImportadores == id);
        }
    }
}
