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
    public class ReservoriosController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public ReservoriosController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Reservorios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reservorios>>> GetReservorios()
        {
            return await _context.Reservorios.ToListAsync();
        }

        // GET: api/Reservorios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reservorios>> GetReservorios(int id)
        {
            var reservorios = await _context.Reservorios.FindAsync(id);

            if (reservorios == null)
            {
                return NotFound();
            }

            return reservorios;
        }

      
    }
}
