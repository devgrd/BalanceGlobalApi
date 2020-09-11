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

    
    }
}
