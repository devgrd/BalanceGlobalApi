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
    public class ConsumoEnergeticoController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public ConsumoEnergeticoController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/ConsumoEnergeticoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsumoEnergetico>>> GetConsumoEnergetico()
        {
            return await _context.ConsumoEnergetico.ToListAsync();
        }

        // GET: api/ConsumoEnergeticoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsumoEnergetico>> GetConsumoEnergetico(int id)
        {
            var consumoEnergetico = await _context.ConsumoEnergetico.FindAsync(id);

            if (consumoEnergetico == null)
            {
                return NotFound();
            }

            return consumoEnergetico;
        }

      
    }
}
