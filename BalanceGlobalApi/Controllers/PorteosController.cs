
using BalanceGlobal.Models;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            var _model = await _service.ReadPorteos(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPorteos(int id, PorteosModel model)
        {
            if (id != model.IdPorteos)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdatePorteos(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadPorteos(id.ToString()) == null)
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
        public async Task<ActionResult<PorteosModel>> PostPorteos(PorteosModel model)
        {
            var _model = await _service.CreatePorteos(model);
            return CreatedAtAction("GetPorteos", new { id = _model.IdPorteos }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PorteosModel>> DeletePorteos(int id)
        {
            var _model = await _service.ReadPorteos(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeletePorteos(id.ToString());

            return _model;
        }

    }
}