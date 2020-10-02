
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
    public class FlujosController : ControllerBase
    {
        private readonly IFlujosService _service;

        public FlujosController(IFlujosService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlujosModel>>> GetFlujos()
        {
            return await _service.ReadFlujos();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FlujosModel>> GetFlujos(int id)
        {
            var _model = await _service.ReadFlujos(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlujos(int id, FlujosModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdFlujos)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateFlujos(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadFlujos(id) == null)
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
        public async Task<ActionResult<FlujosModel>> PostFlujos(FlujosModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateFlujos(model, userName);
            return CreatedAtAction("GetFlujos", new { id = _model.IdFlujos }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FlujosModel>> DeleteFlujos(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadFlujos(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteFlujos(id, userName);

            return _model;
        }

    }
}