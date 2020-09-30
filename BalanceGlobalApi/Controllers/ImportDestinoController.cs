
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
    public class ImportDestinoController : ControllerBase
    {
        private readonly IImportDestinoService _service;

        public ImportDestinoController(IImportDestinoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImportDestinoModel>>> GetImportDestino()
        {
            return await _service.ReadImportDestino();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ImportDestinoModel>> GetImportDestino(int id)
        {
            var _model = await _service.ReadImportDestino(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutImportDestino(int id, ImportDestinoModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImportDestino)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateImportDestino(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadImportDestino(id.ToString()) == null)
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
        public async Task<ActionResult<ImportDestinoModel>> PostImportDestino(ImportDestinoModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateImportDestino(model, userName);
            return CreatedAtAction("GetImportDestino", new { id = _model.IdImportDestino }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ImportDestinoModel>> DeleteImportDestino(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadImportDestino(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteImportDestino(id.ToString(), userName);

            return _model;
        }

    }
}