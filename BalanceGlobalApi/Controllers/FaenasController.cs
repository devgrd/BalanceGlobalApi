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
    public class FaenasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public FaenasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Faenas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Faenas>>> GetFaenas()
        {
            return await _context.Faenas.ToListAsync();
        }

        // GET: api/Faenas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Faenas>> GetFaenas(int id)
        {
            var faenas = await _context.Faenas.FindAsync(id);

            if (faenas == null)
            {
                return NotFound();
            }

            return faenas;
        }

      
    }
}
