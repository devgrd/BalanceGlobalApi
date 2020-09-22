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
    public class SchemaColumnsController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public SchemaColumnsController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/SchemaColumns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchemaColumns>>> GetSchemaColumns()
        {
            return await _context.SchemaColumns.ToListAsync();
        }

        // GET: api/SchemaColumns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SchemaColumns>> GetSchemaColumns(int id)
        {
            var schemaColumns = await _context.SchemaColumns.FindAsync(id);

            if (schemaColumns == null)
            {
                return NotFound();
            }

            return schemaColumns;
        }

        // PUT: api/SchemaColumns/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchemaColumns(int id, SchemaColumns schemaColumns)
        {
            if (id != schemaColumns.IdSchemaColumns)
            {
                return BadRequest();
            }

            _context.Entry(schemaColumns).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchemaColumnsExists(id))
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

        // POST: api/SchemaColumns
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SchemaColumns>> PostSchemaColumns(SchemaColumns schemaColumns)
        {
            _context.SchemaColumns.Add(schemaColumns);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSchemaColumns", new { id = schemaColumns.IdSchemaColumns }, schemaColumns);
        }

        // DELETE: api/SchemaColumns/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SchemaColumns>> DeleteSchemaColumns(int id)
        {
            var schemaColumns = await _context.SchemaColumns.FindAsync(id);
            if (schemaColumns == null)
            {
                return NotFound();
            }

            _context.SchemaColumns.Remove(schemaColumns);
            await _context.SaveChangesAsync();

            return schemaColumns;
        }

        private bool SchemaColumnsExists(int id)
        {
            return _context.SchemaColumns.Any(e => e.IdSchemaColumns == id);
        }
    }
}
