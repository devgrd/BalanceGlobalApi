
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
    public class TasaEvaporacionController : ControllerBase
    {
        private readonly ITasaEvaporacionService _service;

        public TasaEvaporacionController(ITasaEvaporacionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TasaEvaporacionModel>>> GetTasaEvaporacion()
        {
            return await _service.ReadTasaEvaporacion();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TasaEvaporacionModel>> GetTasaEvaporacion(int id)
        {
            var _model = await _service.ReadTasaEvaporacion(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTasaEvaporacion(int id, TasaEvaporacionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTasaEvaporacion)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateTasaEvaporacion(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadTasaEvaporacion(id) == null)
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
        public async Task<ActionResult<TasaEvaporacionModel>> PostTasaEvaporacion(TasaEvaporacionModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateTasaEvaporacion(model, userName);
            return CreatedAtAction("GetTasaEvaporacion", new { id = _model.IdTasaEvaporacion }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TasaEvaporacionModel>> DeleteTasaEvaporacion(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadTasaEvaporacion(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteTasaEvaporacion(id, userName);

            return _model;
        }

    }
}