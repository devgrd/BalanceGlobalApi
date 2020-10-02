
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
    public class EvaporacionInfiltracionController : ControllerBase
    {
        private readonly IEvaporacionInfiltracionService _service;

        public EvaporacionInfiltracionController(IEvaporacionInfiltracionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EvaporacionInfiltracionModel>>> GetEvaporacionInfiltracion()
        {
            return await _service.ReadEvaporacionInfiltracion();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EvaporacionInfiltracionModel>> GetEvaporacionInfiltracion(int id)
        {
            var _model = await _service.ReadEvaporacionInfiltracion(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvaporacionInfiltracion(int id, EvaporacionInfiltracionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdEvaporacionInfiltracion)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateEvaporacionInfiltracion(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadEvaporacionInfiltracion(id) == null)
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
        public async Task<ActionResult<EvaporacionInfiltracionModel>> PostEvaporacionInfiltracion(EvaporacionInfiltracionModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateEvaporacionInfiltracion(model, userName);
            return CreatedAtAction("GetEvaporacionInfiltracion", new { id = _model.IdEvaporacionInfiltracion }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<EvaporacionInfiltracionModel>> DeleteEvaporacionInfiltracion(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadEvaporacionInfiltracion(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteEvaporacionInfiltracion(id, userName);

            return _model;
        }

    }
}