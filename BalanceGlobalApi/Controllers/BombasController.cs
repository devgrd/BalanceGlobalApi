
using BalanceGlobal.Models;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BombasController : ControllerBase
    {
        private readonly IBombasService _service;

        public BombasController(IBombasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BombasModel>>> GetBombas()
        {
            return await _service.ReadBombas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BombasModel>> GetBombas(int id)
        {
            var _model = await _service.ReadBombas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBombas(int id, BombasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdBombas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateBombas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadBombas(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<BombasModel>> PostBombas(BombasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateBombas(model, userName);
            return CreatedAtAction("GetBombas", new { id = _model.IdBombas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<BombasModel>> DeleteBombas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadBombas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteBombas(id, userName);

            return _model;
        }

    }
}