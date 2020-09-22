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
    public class ImportacionesUserParValuesController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public ImportacionesUserParValuesController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/ImportacionesUserParValues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImportacionesUserParValues>>> GetImportacionesUserParValues()
        {
            return await _context.ImportacionesUserParValues.ToListAsync();
        }

        // GET: api/ImportacionesUserParValues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImportacionesUserParValues>> GetImportacionesUserParValues(int id)
        {
            var importacionesUserParValues = await _context.ImportacionesUserParValues.FindAsync(id);

            if (importacionesUserParValues == null)
            {
                return NotFound();
            }

            return importacionesUserParValues;
        }

        // PUT: api/ImportacionesUserParValues/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImportacionesUserParValues(int id, ImportacionesUserParValues importacionesUserParValues)
        {
            if (id != importacionesUserParValues.IdImportacionesUserParValues)
            {
                return BadRequest();
            }

            _context.Entry(importacionesUserParValues).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImportacionesUserParValuesExists(id))
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

        // POST: api/ImportacionesUserParValues
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ImportacionesUserParValues>> PostImportacionesUserParValues(ImportacionesUserParValues importacionesUserParValues)
        {
            _context.ImportacionesUserParValues.Add(importacionesUserParValues);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImportacionesUserParValues", new { id = importacionesUserParValues.IdImportacionesUserParValues }, importacionesUserParValues);
        }

        // DELETE: api/ImportacionesUserParValues/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ImportacionesUserParValues>> DeleteImportacionesUserParValues(int id)
        {
            var importacionesUserParValues = await _context.ImportacionesUserParValues.FindAsync(id);
            if (importacionesUserParValues == null)
            {
                return NotFound();
            }

            _context.ImportacionesUserParValues.Remove(importacionesUserParValues);
            await _context.SaveChangesAsync();

            return importacionesUserParValues;
        }

        private bool ImportacionesUserParValuesExists(int id)
        {
            return _context.ImportacionesUserParValues.Any(e => e.IdImportacionesUserParValues == id);
        }
    }
}
