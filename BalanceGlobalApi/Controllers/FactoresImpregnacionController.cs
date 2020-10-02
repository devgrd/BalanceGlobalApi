
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
    public class FactoresImpregnacionController : ControllerBase
    {
        private readonly IFactoresImpregnacionService _service;

        public FactoresImpregnacionController(IFactoresImpregnacionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FactoresImpregnacionModel>>> GetFactoresImpregnacion()
        {
            return await _service.ReadFactoresImpregnacion();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FactoresImpregnacionModel>> GetFactoresImpregnacion(int id)
        {
            var _model = await _service.ReadFactoresImpregnacion(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFactoresImpregnacion(int id, FactoresImpregnacionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdFactoresImpregnacion)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateFactoresImpregnacion(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadFactoresImpregnacion(id) == null)
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
        public async Task<ActionResult<FactoresImpregnacionModel>> PostFactoresImpregnacion(FactoresImpregnacionModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateFactoresImpregnacion(model, userName);
            return CreatedAtAction("GetFactoresImpregnacion", new { id = _model.IdFactoresImpregnacion }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FactoresImpregnacionModel>> DeleteFactoresImpregnacion(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadFactoresImpregnacion(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteFactoresImpregnacion(id, userName);

            return _model;
        }

    }
}