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
    public class ImportacionesController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public ImportacionesController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Importaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Importaciones>>> GetImportaciones()
        {
            return await _context.Importaciones.ToListAsync();
        }

        // GET: api/Importaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Importaciones>> GetImportaciones(int id)
        {
            var importaciones = await _context.Importaciones.FindAsync(id);

            if (importaciones == null)
            {
                return NotFound();
            }

            return importaciones;
        }

        // PUT: api/Importaciones/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImportaciones(int id, Importaciones importaciones)
        {
            if (id != importaciones.IdImportaciones)
            {
                return BadRequest();
            }

            _context.Entry(importaciones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImportacionesExists(id))
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

        // POST: api/Importaciones
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Importaciones>> PostImportaciones(Importaciones importaciones)
        {
            _context.Importaciones.Add(importaciones);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ImportacionesExists(importaciones.IdImportaciones))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetImportaciones", new { id = importaciones.IdImportaciones }, importaciones);
        }

        // DELETE: api/Importaciones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Importaciones>> DeleteImportaciones(int id)
        {
            var importaciones = await _context.Importaciones.FindAsync(id);
            if (importaciones == null)
            {
                return NotFound();
            }

            _context.Importaciones.Remove(importaciones);
            await _context.SaveChangesAsync();

            return importaciones;
        }

        private bool ImportacionesExists(int id)
        {
            return _context.Importaciones.Any(e => e.IdImportaciones == id);
        }
    }
}
