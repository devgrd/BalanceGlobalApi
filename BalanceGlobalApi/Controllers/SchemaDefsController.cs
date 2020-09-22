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
    public class SchemaDefsController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public SchemaDefsController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/SchemaDefs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchemaDef>>> GetSchemaDef()
        {
            return await _context.SchemaDef.ToListAsync();
        }

        // GET: api/SchemaDefs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SchemaDef>> GetSchemaDef(int id)
        {
            var schemaDef = await _context.SchemaDef.FindAsync(id);

            if (schemaDef == null)
            {
                return NotFound();
            }

            return schemaDef;
        }

        // PUT: api/SchemaDefs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchemaDef(int id, SchemaDef schemaDef)
        {
            if (id != schemaDef.IdSchemaDef)
            {
                return BadRequest();
            }

            _context.Entry(schemaDef).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchemaDefExists(id))
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

        // POST: api/SchemaDefs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SchemaDef>> PostSchemaDef(SchemaDef schemaDef)
        {
            _context.SchemaDef.Add(schemaDef);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSchemaDef", new { id = schemaDef.IdSchemaDef }, schemaDef);
        }

        // DELETE: api/SchemaDefs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SchemaDef>> DeleteSchemaDef(int id)
        {
            var schemaDef = await _context.SchemaDef.FindAsync(id);
            if (schemaDef == null)
            {
                return NotFound();
            }

            _context.SchemaDef.Remove(schemaDef);
            await _context.SaveChangesAsync();

            return schemaDef;
        }

        private bool SchemaDefExists(int id)
        {
            return _context.SchemaDef.Any(e => e.IdSchemaDef == id);
        }
    }
}
