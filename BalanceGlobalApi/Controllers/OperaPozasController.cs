
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
    public class OperaPozasController : ControllerBase
    {
        private readonly IOperaPozasService _service;

        public OperaPozasController(IOperaPozasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OperaPozasModel>>> GetOperaPozas()
        {
            return await _service.ReadOperaPozas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OperaPozasModel>> GetOperaPozas(int id)
        {
            var _model = await _service.ReadOperaPozas(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOperaPozas(int id, OperaPozasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdOperaPozas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateOperaPozas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadOperaPozas(id.ToString()) == null)
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
        public async Task<ActionResult<OperaPozasModel>> PostOperaPozas(OperaPozasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateOperaPozas(model, userName);
            return CreatedAtAction("GetOperaPozas", new { id = _model.IdOperaPozas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OperaPozasModel>> DeleteOperaPozas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadOperaPozas(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteOperaPozas(id.ToString(), userName);

            return _model;
        }

    }
}