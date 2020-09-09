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
    public class SistemasSubSistemasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public SistemasSubSistemasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/SistemasSubSistemas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SistemasSubSistemas>>> GetSistemasSubSistemas()
        {
            return await _context.SistemasSubSistemas.ToListAsync();
        }

        // GET: api/SistemasSubSistemas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SistemasSubSistemas>> GetSistemasSubSistemas(int id)
        {
            var sistemasSubSistemas = await _context.SistemasSubSistemas.FindAsync(id);

            if (sistemasSubSistemas == null)
            {
                return NotFound();
            }

            return sistemasSubSistemas;
        }

        // PUT: api/SistemasSubSistemas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSistemasSubSistemas(int id, SistemasSubSistemas sistemasSubSistemas)
        {
            if (id != sistemasSubSistemas.IdSistemasSubsistemas)
            {
                return BadRequest();
            }

            _context.Entry(sistemasSubSistemas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SistemasSubSistemasExists(id))
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

        // POST: api/SistemasSubSistemas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SistemasSubSistemas>> PostSistemasSubSistemas(SistemasSubSistemas sistemasSubSistemas)
        {
            _context.SistemasSubSistemas.Add(sistemasSubSistemas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSistemasSubSistemas", new { id = sistemasSubSistemas.IdSistemasSubsistemas }, sistemasSubSistemas);
        }

        // DELETE: api/SistemasSubSistemas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SistemasSubSistemas>> DeleteSistemasSubSistemas(int id)
        {
            var sistemasSubSistemas = await _context.SistemasSubSistemas.FindAsync(id);
            if (sistemasSubSistemas == null)
            {
                return NotFound();
            }

            _context.SistemasSubSistemas.Remove(sistemasSubSistemas);
            await _context.SaveChangesAsync();

            return sistemasSubSistemas;
        }

        private bool SistemasSubSistemasExists(int id)
        {
            return _context.SistemasSubSistemas.Any(e => e.IdSistemasSubsistemas == id);
        }
    }
}
