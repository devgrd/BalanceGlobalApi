
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
    public class ConsReactivosController : ControllerBase
    {
        private readonly IConsReactivosService _service;

        public ConsReactivosController(IConsReactivosService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsReactivosModel>>> GetConsReactivos()
        {
            return await _service.ReadConsReactivos();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ConsReactivosModel>> GetConsReactivos(int id)
        {
            var _model = await _service.ReadConsReactivos(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsReactivos(int id, ConsReactivosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsReactivos)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateConsReactivos(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadConsReactivos(id) == null)
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
        public async Task<ActionResult<ConsReactivosModel>> PostConsReactivos(ConsReactivosModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateConsReactivos(model, userName);
            return CreatedAtAction("GetConsReactivos", new { id = _model.IdConsReactivos }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ConsReactivosModel>> DeleteConsReactivos(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadConsReactivos(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteConsReactivos(id, userName);

            return _model;
        }

    }
}