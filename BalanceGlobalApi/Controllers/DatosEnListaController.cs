
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
    public class DatosEnListaController : ControllerBase
    {
        private readonly IDatosEnListaService _service;

        public DatosEnListaController(IDatosEnListaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DatosEnListaModel>>> GetDatosEnLista()
        {
            return await _service.ReadDatosEnLista();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DatosEnListaModel>> GetDatosEnLista(int id)
        {
            var _model = await _service.ReadDatosEnLista(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDatosEnLista(int id, DatosEnListaModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdDatosEnLista)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateDatosEnLista(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadDatosEnLista(id) == null)
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
        public async Task<ActionResult<DatosEnListaModel>> PostDatosEnLista(DatosEnListaModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateDatosEnLista(model, userName);
            return CreatedAtAction("GetDatosEnLista", new { id = _model.IdDatosEnLista }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<DatosEnListaModel>> DeleteDatosEnLista(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadDatosEnLista(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteDatosEnLista(id, userName);

            return _model;
        }

    }
}