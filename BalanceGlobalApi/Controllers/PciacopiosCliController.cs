
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
    public class PciacopiosCliController : ControllerBase
    {
        private readonly IPciacopiosCliService _service;

        public PciacopiosCliController(IPciacopiosCliService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PciacopiosCliModel>>> GetPciacopiosCli()
        {
            return await _service.ReadPciacopiosCli();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PciacopiosCliModel>> GetPciacopiosCli(int id)
        {
            var _model = await _service.ReadPciacopiosCli(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPciacopiosCli(int id, PciacopiosCliModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPciacopiosCli)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdatePciacopiosCli(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadPciacopiosCli(id) == null)
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
        public async Task<ActionResult<PciacopiosCliModel>> PostPciacopiosCli(PciacopiosCliModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreatePciacopiosCli(model, userName);
            return CreatedAtAction("GetPciacopiosCli", new { id = _model.IdPciacopiosCli }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PciacopiosCliModel>> DeletePciacopiosCli(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadPciacopiosCli(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeletePciacopiosCli(id, userName);

            return _model;
        }

    }
}