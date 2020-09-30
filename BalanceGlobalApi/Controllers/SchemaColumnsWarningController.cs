
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
    public class SchemaColumnsWarningController : ControllerBase
    {
        private readonly ISchemaColumnsWarningService _service;

        public SchemaColumnsWarningController(ISchemaColumnsWarningService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchemaColumnsWarningModel>>> GetSchemaColumnsWarning()
        {
            return await _service.ReadSchemaColumnsWarning();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SchemaColumnsWarningModel>> GetSchemaColumnsWarning(int id)
        {
            var _model = await _service.ReadSchemaColumnsWarning(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchemaColumnsWarning(int id, SchemaColumnsWarningModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdSchemaColumnsWarning)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateSchemaColumnsWarning(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadSchemaColumnsWarning(id.ToString()) == null)
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
        public async Task<ActionResult<SchemaColumnsWarningModel>> PostSchemaColumnsWarning(SchemaColumnsWarningModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateSchemaColumnsWarning(model, userName);
            return CreatedAtAction("GetSchemaColumnsWarning", new { id = _model.IdSchemaColumnsWarning }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SchemaColumnsWarningModel>> DeleteSchemaColumnsWarning(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadSchemaColumnsWarning(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteSchemaColumnsWarning(id.ToString(), userName);

            return _model;
        }

    }
}