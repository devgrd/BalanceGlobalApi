
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
    public class MensajesImportacionController : ControllerBase
    {
        private readonly IMensajesImportacionService _service;

        public MensajesImportacionController(IMensajesImportacionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MensajesImportacionModel>>> GetMensajesImportacion()
        {
            return await _service.ReadMensajesImportacion();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MensajesImportacionModel>> GetMensajesImportacion(int id)
        {
            var _model = await _service.ReadMensajesImportacion(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMensajesImportacion(int id, MensajesImportacionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdMensajesImportacion)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateMensajesImportacion(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadMensajesImportacion(id.ToString()) == null)
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
        public async Task<ActionResult<MensajesImportacionModel>> PostMensajesImportacion(MensajesImportacionModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateMensajesImportacion(model, userName);
            return CreatedAtAction("GetMensajesImportacion", new { id = _model.IdMensajesImportacion }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MensajesImportacionModel>> DeleteMensajesImportacion(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadMensajesImportacion(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteMensajesImportacion(id.ToString(), userName);

            return _model;
        }

    }
}