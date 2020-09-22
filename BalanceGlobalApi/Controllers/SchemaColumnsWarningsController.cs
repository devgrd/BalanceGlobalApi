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
    public class SchemaColumnsWarningsController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public SchemaColumnsWarningsController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/SchemaColumnsWarnings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchemaColumnsWarning>>> GetSchemaColumnsWarning()
        {
            return await _context.SchemaColumnsWarning.ToListAsync();
        }

        // GET: api/SchemaColumnsWarnings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SchemaColumnsWarning>> GetSchemaColumnsWarning(int id)
        {
            var schemaColumnsWarning = await _context.SchemaColumnsWarning.FindAsync(id);

            if (schemaColumnsWarning == null)
            {
                return NotFound();
            }

            return schemaColumnsWarning;
        }

        // PUT: api/SchemaColumnsWarnings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchemaColumnsWarning(int id, SchemaColumnsWarning schemaColumnsWarning)
        {
            if (id != schemaColumnsWarning.IdSchemaColumnsWarning)
            {
                return BadRequest();
            }

            _context.Entry(schemaColumnsWarning).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchemaColumnsWarningExists(id))
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

        // POST: api/SchemaColumnsWarnings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SchemaColumnsWarning>> PostSchemaColumnsWarning(SchemaColumnsWarning schemaColumnsWarning)
        {
            _context.SchemaColumnsWarning.Add(schemaColumnsWarning);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSchemaColumnsWarning", new { id = schemaColumnsWarning.IdSchemaColumnsWarning }, schemaColumnsWarning);
        }

        // DELETE: api/SchemaColumnsWarnings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SchemaColumnsWarning>> DeleteSchemaColumnsWarning(int id)
        {
            var schemaColumnsWarning = await _context.SchemaColumnsWarning.FindAsync(id);
            if (schemaColumnsWarning == null)
            {
                return NotFound();
            }

            _context.SchemaColumnsWarning.Remove(schemaColumnsWarning);
            await _context.SaveChangesAsync();

            return schemaColumnsWarning;
        }

        private bool SchemaColumnsWarningExists(int id)
        {
            return _context.SchemaColumnsWarning.Any(e => e.IdSchemaColumnsWarning == id);
        }
    }
}
