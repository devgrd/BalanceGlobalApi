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
    public class MensajesImportacionsController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public MensajesImportacionsController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/MensajesImportacions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MensajesImportacion>>> GetMensajesImportacion()
        {
            return await _context.MensajesImportacion.ToListAsync();
        }

        // GET: api/MensajesImportacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MensajesImportacion>> GetMensajesImportacion(int id)
        {
            var mensajesImportacion = await _context.MensajesImportacion.FindAsync(id);

            if (mensajesImportacion == null)
            {
                return NotFound();
            }

            return mensajesImportacion;
        }

        // PUT: api/MensajesImportacions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMensajesImportacion(int id, MensajesImportacion mensajesImportacion)
        {
            if (id != mensajesImportacion.IdMensajesImportacion)
            {
                return BadRequest();
            }

            _context.Entry(mensajesImportacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MensajesImportacionExists(id))
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

        // POST: api/MensajesImportacions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MensajesImportacion>> PostMensajesImportacion(MensajesImportacion mensajesImportacion)
        {
            _context.MensajesImportacion.Add(mensajesImportacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMensajesImportacion", new { id = mensajesImportacion.IdMensajesImportacion }, mensajesImportacion);
        }

        // DELETE: api/MensajesImportacions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MensajesImportacion>> DeleteMensajesImportacion(int id)
        {
            var mensajesImportacion = await _context.MensajesImportacion.FindAsync(id);
            if (mensajesImportacion == null)
            {
                return NotFound();
            }

            _context.MensajesImportacion.Remove(mensajesImportacion);
            await _context.SaveChangesAsync();

            return mensajesImportacion;
        }

        private bool MensajesImportacionExists(int id)
        {
            return _context.MensajesImportacion.Any(e => e.IdMensajesImportacion == id);
        }
    }
}
