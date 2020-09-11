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
    public class CosechasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public CosechasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Cosechas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cosechas>>> GetCosechas()
        {
            return await _context.Cosechas.ToListAsync();
        }

        // GET: api/Cosechas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cosechas>> GetCosechas(int id)
        {
            var cosechas = await _context.Cosechas.FindAsync(id);

            if (cosechas == null)
            {
                return NotFound();
            }

            return cosechas;
        }

      
    }
}
