
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
    public class SchemaDefController : ControllerBase
    {
        private readonly ISchemaDefService _service;

        public SchemaDefController(ISchemaDefService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchemaDefModel>>> GetSchemaDef()
        {
            return await _service.ReadSchemaDef();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SchemaDefModel>> GetSchemaDef(int id)
        {
            var _model = await _service.ReadSchemaDef(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchemaDef(int id, SchemaDefModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdSchemaDef)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateSchemaDef(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadSchemaDef(id) == null)
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
        public async Task<ActionResult<SchemaDefModel>> PostSchemaDef(SchemaDefModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateSchemaDef(model, userName);
            return CreatedAtAction("GetSchemaDef", new { id = _model.IdSchemaDef }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SchemaDefModel>> DeleteSchemaDef(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadSchemaDef(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteSchemaDef(id, userName);

            return _model;
        }

    }
}