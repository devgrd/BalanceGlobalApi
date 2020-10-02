
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
    public class PciacopiosOrigenController : ControllerBase
    {
        private readonly IPciacopiosOrigenService _service;

        public PciacopiosOrigenController(IPciacopiosOrigenService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PciacopiosOrigenModel>>> GetPciacopiosOrigen()
        {
            return await _service.ReadPciacopiosOrigen();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PciacopiosOrigenModel>> GetPciacopiosOrigen(int id)
        {
            var _model = await _service.ReadPciacopiosOrigen(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPciacopiosOrigen(int id, PciacopiosOrigenModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPciacopiosOrigen)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdatePciacopiosOrigen(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadPciacopiosOrigen(id) == null)
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
        public async Task<ActionResult<PciacopiosOrigenModel>> PostPciacopiosOrigen(PciacopiosOrigenModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreatePciacopiosOrigen(model, userName);
            return CreatedAtAction("GetPciacopiosOrigen", new { id = _model.IdPciacopiosOrigen }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PciacopiosOrigenModel>> DeletePciacopiosOrigen(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadPciacopiosOrigen(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeletePciacopiosOrigen(id, userName);

            return _model;
        }

    }
}