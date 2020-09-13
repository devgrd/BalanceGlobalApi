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
    public class ExtraccionesController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public ExtraccionesController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/Extraccions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Extraccion>>> GetExtraccion()
        {
            return await _context.Extraccion.ToListAsync();
        }

        // GET: api/Extraccions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Extraccion>> GetExtraccion(int id)
        {
            var extraccion = await _context.Extraccion.FindAsync(id);

            if (extraccion == null)
            {
                return NotFound();
            }

            return extraccion;
        }

      
    }
}
