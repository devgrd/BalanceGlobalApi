
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
    public class ImportacionesController : ControllerBase
    {
        private readonly IImportacionesService _service;

        public ImportacionesController(IImportacionesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImportacionesModel>>> GetImportaciones()
        {
            return await _service.ReadImportaciones();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ImportacionesModel>> GetImportaciones(int id)
        {
            var _model = await _service.ReadImportaciones(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutImportaciones(int id, ImportacionesModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImportaciones)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateImportaciones(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadImportaciones(id) == null)
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
        public async Task<ActionResult<ImportacionesModel>> PostImportaciones(ImportacionesModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateImportaciones(model, userName);
            return CreatedAtAction("GetImportaciones", new { id = _model.IdImportaciones }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ImportacionesModel>> DeleteImportaciones(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadImportaciones(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteImportaciones(id, userName);

            return _model;
        }

    }
}