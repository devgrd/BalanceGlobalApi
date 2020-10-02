
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
    public class ImportadoresController : ControllerBase
    {
        private readonly IImportadoresService _service;

        public ImportadoresController(IImportadoresService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImportadoresModel>>> GetImportadores()
        {
            return await _service.ReadImportadores();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ImportadoresModel>> GetImportadores(int id)
        {
            var _model = await _service.ReadImportadores(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutImportadores(int id, ImportadoresModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImportadores)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateImportadores(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadImportadores(id) == null)
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
        public async Task<ActionResult<ImportadoresModel>> PostImportadores(ImportadoresModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateImportadores(model, userName);
            return CreatedAtAction("GetImportadores", new { id = _model.IdImportadores }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ImportadoresModel>> DeleteImportadores(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadImportadores(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteImportadores(id, userName);

            return _model;
        }

    }
}