
using BalanceGlobal.Models;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportacionesUserParValuesController : ControllerBase
    {
        private readonly IImportacionesUserParValuesService _service;

        public ImportacionesUserParValuesController(IImportacionesUserParValuesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImportacionesUserParValuesModel>>> GetImportacionesUserParValues()
        {
            return await _service.ReadImportacionesUserParValues();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ImportacionesUserParValuesModel>> GetImportacionesUserParValues(int id)
        {
            var _model = await _service.ReadImportacionesUserParValues(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutImportacionesUserParValues(int id, ImportacionesUserParValuesModel model)
        {
            if (id != model.IdImportacionesUserParValues)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateImportacionesUserParValues(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadImportacionesUserParValues(id.ToString()) == null)
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
        public async Task<ActionResult<ImportacionesUserParValuesModel>> PostImportacionesUserParValues(ImportacionesUserParValuesModel model)
        {
            var _model = await _service.CreateImportacionesUserParValues(model);
            return CreatedAtAction("GetImportacionesUserParValues", new { id = _model.IdImportacionesUserParValues }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ImportacionesUserParValuesModel>> DeleteImportacionesUserParValues(int id)
        {
            var _model = await _service.ReadImportacionesUserParValues(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteImportacionesUserParValues(id.ToString());

            return _model;
        }

    }
}