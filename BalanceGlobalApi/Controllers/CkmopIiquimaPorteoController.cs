
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
    public class CkmopIiquimaPorteoController : ControllerBase
    {
        private readonly ICkmopIiquimaPorteoService _service;

        public CkmopIiquimaPorteoController(ICkmopIiquimaPorteoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CkmopIiquimaPorteoModel>>> GetCkmopIiquimaPorteo()
        {
            return await _service.ReadCkmopIiquimaPorteo();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CkmopIiquimaPorteoModel>> GetCkmopIiquimaPorteo(int id)
        {
            var _model = await _service.ReadCkmopIiquimaPorteo(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCkmopIiquimaPorteo(int id, CkmopIiquimaPorteoModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCkmopIiquimaPorteo)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateCkmopIiquimaPorteo(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadCkmopIiquimaPorteo(id) == null)
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
        public async Task<ActionResult<CkmopIiquimaPorteoModel>> PostCkmopIiquimaPorteo(CkmopIiquimaPorteoModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateCkmopIiquimaPorteo(model, userName);
            return CreatedAtAction("GetCkmopIiquimaPorteo", new { id = _model.IdCkmopIiquimaPorteo }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CkmopIiquimaPorteoModel>> DeleteCkmopIiquimaPorteo(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadCkmopIiquimaPorteo(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteCkmopIiquimaPorteo(id, userName);

            return _model;
        }

    }
}