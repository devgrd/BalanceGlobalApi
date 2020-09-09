﻿using System;
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
    public class SubsistemasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public SubsistemasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Subsistemas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subsistemas>>> GetSubsistemas()
        {
            return await _context.Subsistemas.ToListAsync();
        }

        // GET: api/Subsistemas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Subsistemas>> GetSubsistemas(int id)
        {
            var subsistemas = await _context.Subsistemas.FindAsync(id);

            if (subsistemas == null)
            {
                return NotFound();
            }

            return subsistemas;
        }

        // PUT: api/Subsistemas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubsistemas(int id, Subsistemas subsistemas)
        {
            if (id != subsistemas.IdSubsistemas)
            {
                return BadRequest();
            }

            _context.Entry(subsistemas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubsistemasExists(id))
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

        // POST: api/Subsistemas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Subsistemas>> PostSubsistemas(Subsistemas subsistemas)
        {
            _context.Subsistemas.Add(subsistemas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubsistemas", new { id = subsistemas.IdSubsistemas }, subsistemas);
        }

        // DELETE: api/Subsistemas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Subsistemas>> DeleteSubsistemas(int id)
        {
            var subsistemas = await _context.Subsistemas.FindAsync(id);
            if (subsistemas == null)
            {
                return NotFound();
            }

            _context.Subsistemas.Remove(subsistemas);
            await _context.SaveChangesAsync();

            return subsistemas;
        }

        private bool SubsistemasExists(int id)
        {
            return _context.Subsistemas.Any(e => e.IdSubsistemas == id);
        }
    }
}
