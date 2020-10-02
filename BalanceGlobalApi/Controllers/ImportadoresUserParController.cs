
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
    public class ImportadoresUserParController : ControllerBase
    {
        private readonly IImportadoresUserParService _service;

        public ImportadoresUserParController(IImportadoresUserParService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImportadoresUserParModel>>> GetImportadoresUserPar()
        {
            return await _service.ReadImportadoresUserPar();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ImportadoresUserParModel>> GetImportadoresUserPar(int id)
        {
            var _model = await _service.ReadImportadoresUserPar(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutImportadoresUserPar(int id, ImportadoresUserParModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImportadoresUserPar)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateImportadoresUserPar(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadImportadoresUserPar(id) == null)
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
        public async Task<ActionResult<ImportadoresUserParModel>> PostImportadoresUserPar(ImportadoresUserParModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateImportadoresUserPar(model, userName);
            return CreatedAtAction("GetImportadoresUserPar", new { id = _model.IdImportadoresUserPar }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ImportadoresUserParModel>> DeleteImportadoresUserPar(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadImportadoresUserPar(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteImportadoresUserPar(id, userName);

            return _model;
        }

    }
}