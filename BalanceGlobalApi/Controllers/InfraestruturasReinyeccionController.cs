
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
    public class InfraestruturasReinyeccionController : ControllerBase
    {
        private readonly IInfraestruturasReinyeccionService _service;

        public InfraestruturasReinyeccionController(IInfraestruturasReinyeccionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InfraestruturasReinyeccionModel>>> GetInfraestruturasReinyeccion()
        {
            return await _service.ReadInfraestruturasReinyeccion();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InfraestruturasReinyeccionModel>> GetInfraestruturasReinyeccion(int id)
        {
            var _model = await _service.ReadInfraestruturasReinyeccion(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInfraestruturasReinyeccion(int id, InfraestruturasReinyeccionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdInfraestructurasReinyeccion)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateInfraestruturasReinyeccion(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadInfraestruturasReinyeccion(id) == null)
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
        public async Task<ActionResult<InfraestruturasReinyeccionModel>> PostInfraestruturasReinyeccion(InfraestruturasReinyeccionModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateInfraestruturasReinyeccion(model, userName);
            return CreatedAtAction("GetInfraestruturasReinyeccion", new { id = _model.IdInfraestructurasReinyeccion }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<InfraestruturasReinyeccionModel>> DeleteInfraestruturasReinyeccion(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadInfraestruturasReinyeccion(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteInfraestruturasReinyeccion(id, userName);

            return _model;
        }

    }
}