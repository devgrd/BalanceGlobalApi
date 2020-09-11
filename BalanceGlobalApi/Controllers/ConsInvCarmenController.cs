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
    public class ConsInvCarmenController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;

        public ConsInvCarmenController(BalanceGlobalContext context)
        {
            _context = context;
        }

        // GET: api/ConsInvCarmen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsInvCarmen>>> GetConsInvCarmen()
        {
            return await _context.ConsInvCarmen.ToListAsync();
        }

        // GET: api/ConsInvCarmen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsInvCarmen>> GetConsInvCarmen(int id)
        {
            var consInvCarmen = await _context.ConsInvCarmen.FindAsync(id);

            if (consInvCarmen == null)
            {
                return NotFound();
            }

            return consInvCarmen;
        }

       
    }
}
