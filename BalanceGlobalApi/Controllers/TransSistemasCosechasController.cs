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
    public class TransSistemasCosechasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public TransSistemasCosechasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/TransSistemasCosechas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransSistemasCosechas>>> GetTransSistemasCosechas()
        {
            return await _context.TransSistemasCosechas.ToListAsync();
        }

        // GET: api/TransSistemasCosechas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransSistemasCosechas>> GetTransSistemasCosechas(int id)
        {
            var transSistemasCosechas = await _context.TransSistemasCosechas.FindAsync(id);

            if (transSistemasCosechas == null)
            {
                return NotFound();
            }

            return transSistemasCosechas;
        }

        // PUT: api/TransSistemasCosechas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransSistemasCosechas(int id, TransSistemasCosechas transSistemasCosechas)
        {
            if (id != transSistemasCosechas.IdTransSistemasCosechas)
            {
                return BadRequest();
            }

            _context.Entry(transSistemasCosechas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransSistemasCosechasExists(id))
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

        // POST: api/TransSistemasCosechas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TransSistemasCosechas>> PostTransSistemasCosechas(TransSistemasCosechas transSistemasCosechas)
        {
            _context.TransSistemasCosechas.Add(transSistemasCosechas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransSistemasCosechas", new { id = transSistemasCosechas.IdTransSistemasCosechas }, transSistemasCosechas);
        }

        // DELETE: api/TransSistemasCosechas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TransSistemasCosechas>> DeleteTransSistemasCosechas(int id)
        {
            var transSistemasCosechas = await _context.TransSistemasCosechas.FindAsync(id);
            if (transSistemasCosechas == null)
            {
                return NotFound();
            }

            _context.TransSistemasCosechas.Remove(transSistemasCosechas);
            await _context.SaveChangesAsync();

            return transSistemasCosechas;
        }

        private bool TransSistemasCosechasExists(int id)
        {
            return _context.TransSistemasCosechas.Any(e => e.IdTransSistemasCosechas == id);
        }
    }
}
