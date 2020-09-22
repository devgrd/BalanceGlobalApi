using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BalanceGlobal.Database.Context;
using BalanceGlobal.Database.Tables;
using AutoMapper;
using BalanceGlobal.Entities;

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservoriosController : ControllerBase
    {
        private readonly BalanceGlobalContext _context;
        private readonly IMapper _mapper;

        public ReservoriosController(BalanceGlobalContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Reservorios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservoriosEntity>>> GetReservorios()
        {
            var reservorios = await _context.Reservorios.ToListAsync();
            var result = _mapper.Map<List<ReservoriosEntity>>(reservorios);

            return result;
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
