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
    public class OperaPozasController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public OperaPozasController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/OperaPozas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OperaPozas>>> GetOperaPozas()
        {
            return await _context.OperaPozas.ToListAsync();
        }

        // GET: api/OperaPozas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OperaPozas>> GetOperaPozas(int id)
        {
            var operaPozas = await _context.OperaPozas.FindAsync(id);

            if (operaPozas == null)
            {
                return NotFound();
            }

            return operaPozas;
        }

      
    }
}
