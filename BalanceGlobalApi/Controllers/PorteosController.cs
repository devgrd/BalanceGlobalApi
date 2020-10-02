
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
    public class PorteosController : ControllerBase
    {
        private readonly IPorteosService _service;

        public PorteosController(IPorteosService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PorteosModel>>> GetPorteos()
        {
            return await _service.ReadPorteos();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PorteosModel>> GetPorteos(int id)
        {
            var _model = await _service.ReadPorteos(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPorteos(int id, PorteosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPorteos)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdatePorteos(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadPorteos(id) == null)
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
        public async Task<ActionResult<PorteosModel>> PostPorteos(PorteosModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreatePorteos(model, userName);
            return CreatedAtAction("GetPorteos", new { id = _model.IdPorteos }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PorteosModel>> DeletePorteos(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadPorteos(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeletePorteos(id, userName);

            return _model;
        }

    }
}