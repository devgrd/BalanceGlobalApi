
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
    public class ReactivosController : ControllerBase
    {
        private readonly IReactivosService _service;

        public ReactivosController(IReactivosService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReactivosModel>>> GetReactivos()
        {
            return await _service.ReadReactivos();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReactivosModel>> GetReactivos(int id)
        {
            var _model = await _service.ReadReactivos(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReactivos(int id, ReactivosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdReactivos)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateReactivos(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadReactivos(id) == null)
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
        public async Task<ActionResult<ReactivosModel>> PostReactivos(ReactivosModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateReactivos(model, userName);
            return CreatedAtAction("GetReactivos", new { id = _model.IdReactivos }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ReactivosModel>> DeleteReactivos(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadReactivos(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteReactivos(id, userName);

            return _model;
        }

    }
}