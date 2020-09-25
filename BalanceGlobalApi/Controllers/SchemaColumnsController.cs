
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
    public class SchemaColumnsController : ControllerBase
    {
        private readonly ISchemaColumnsService _service;

        public SchemaColumnsController(ISchemaColumnsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchemaColumnsModel>>> GetSchemaColumns()
        {
            return await _service.ReadSchemaColumns();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SchemaColumnsModel>> GetSchemaColumns(int id)
        {
            var _model = await _service.ReadSchemaColumns(id.ToString());

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchemaColumns(int id, SchemaColumnsModel model)
        {
            if (id != model.IdSchemaColumns)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateSchemaColumns(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadSchemaColumns(id.ToString()) == null)
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
        public async Task<ActionResult<SchemaColumnsModel>> PostSchemaColumns(SchemaColumnsModel model)
        {
            var _model = await _service.CreateSchemaColumns(model);
            return CreatedAtAction("GetSchemaColumns", new { id = _model.IdSchemaColumns }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SchemaColumnsModel>> DeleteSchemaColumns(int id)
        {
            var _model = await _service.ReadSchemaColumns(id.ToString());
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteSchemaColumns(id.ToString());

            return _model;
        }

    }
}