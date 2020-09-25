
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
    public class ReinyeccionController : ControllerBase
    {
        private readonly IReinyeccionService _service;

        public ReinyeccionController(IReinyeccionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReinyeccionModel>>> GetReinyeccion()
        {
            return await _service.ReadReinyeccion();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ReinyeccionModel>> GetReinyeccion(int id)
        {
            var _model = await _service.ReadReinyeccion(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReinyeccion(int id, ReinyeccionModel model)
        {
            if (id != model.IdReinyeccion)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateReinyeccion(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadReinyeccion(id.ToString()) == null)
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
        public async Task<ActionResult<ReinyeccionModel>> PostReinyeccion(ReinyeccionModel model)
        {
            var _model = await _service.CreateReinyeccion(model);
            return CreatedAtAction("GetReinyeccion", new { id = _model.IdReinyeccion }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ReinyeccionModel>> DeleteReinyeccion(int id)
        {
            var _model = await _service.ReadReinyeccion(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteReinyeccion(id.ToString());

            return _model;
        }

    }
}