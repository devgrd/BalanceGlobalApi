
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
    public class TraspasosPlataformasController : ControllerBase
    {
        private readonly ITraspasosPlataformasService _service;

        public TraspasosPlataformasController(ITraspasosPlataformasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TraspasosPlataformasModel>>> GetTraspasosPlataformas()
        {
            return await _service.ReadTraspasosPlataformas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TraspasosPlataformasModel>> GetTraspasosPlataformas(int id)
        {
            var _model = await _service.ReadTraspasosPlataformas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTraspasosPlataformas(int id, TraspasosPlataformasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTraspasosPlataformas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateTraspasosPlataformas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadTraspasosPlataformas(id) == null)
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
        public async Task<ActionResult<TraspasosPlataformasModel>> PostTraspasosPlataformas(TraspasosPlataformasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateTraspasosPlataformas(model, userName);
            return CreatedAtAction("GetTraspasosPlataformas", new { id = _model.IdTraspasosPlataformas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TraspasosPlataformasModel>> DeleteTraspasosPlataformas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadTraspasosPlataformas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteTraspasosPlataformas(id, userName);

            return _model;
        }

    }
}