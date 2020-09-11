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
    public class FaenasSistemasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public FaenasSistemasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/FaenasSistemas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FaenasSistemas>>> GetFaenasSistemas()
        {
            return await _context.FaenasSistemas.ToListAsync();
        }

        // GET: api/FaenasSistemas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FaenasSistemas>> GetFaenasSistemas(int id)
        {
            var faenasSistemas = await _context.FaenasSistemas.FindAsync(id);

            if (faenasSistemas == null)
            {
                return NotFound();
            }

            return faenasSistemas;
        }

      
    }
}
