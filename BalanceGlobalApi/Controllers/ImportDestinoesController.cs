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
    public class ImportDestinoesController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public ImportDestinoesController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/ImportDestinoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImportDestino>>> GetImportDestino()
        {
            return await _context.ImportDestino.ToListAsync();
        }

        // GET: api/ImportDestinoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImportDestino>> GetImportDestino(int id)
        {
            var importDestino = await _context.ImportDestino.FindAsync(id);

            if (importDestino == null)
            {
                return NotFound();
            }

            return importDestino;
        }

        // PUT: api/ImportDestinoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImportDestino(int id, ImportDestino importDestino)
        {
            if (id != importDestino.IdImportDestino)
            {
                return BadRequest();
            }

            _context.Entry(importDestino).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImportDestinoExists(id))
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

        // POST: api/ImportDestinoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ImportDestino>> PostImportDestino(ImportDestino importDestino)
        {
            _context.ImportDestino.Add(importDestino);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImportDestino", new { id = importDestino.IdImportDestino }, importDestino);
        }

        // DELETE: api/ImportDestinoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ImportDestino>> DeleteImportDestino(int id)
        {
            var importDestino = await _context.ImportDestino.FindAsync(id);
            if (importDestino == null)
            {
                return NotFound();
            }

            _context.ImportDestino.Remove(importDestino);
            await _context.SaveChangesAsync();

            return importDestino;
        }

        private bool ImportDestinoExists(int id)
        {
            return _context.ImportDestino.Any(e => e.IdImportDestino == id);
        }
    }
}
