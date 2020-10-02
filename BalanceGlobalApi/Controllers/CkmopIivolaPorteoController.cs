
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
    public class CkmopIivolaPorteoController : ControllerBase
    {
        private readonly ICkmopIivolaPorteoService _service;

        public CkmopIivolaPorteoController(ICkmopIivolaPorteoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CkmopIivolaPorteoModel>>> GetCkmopIivolaPorteo()
        {
            return await _service.ReadCkmopIivolaPorteo();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CkmopIivolaPorteoModel>> GetCkmopIivolaPorteo(int id)
        {
            var _model = await _service.ReadCkmopIivolaPorteo(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCkmopIivolaPorteo(int id, CkmopIivolaPorteoModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCkmopIivolaPorteo)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateCkmopIivolaPorteo(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadCkmopIivolaPorteo(id) == null)
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
        public async Task<ActionResult<CkmopIivolaPorteoModel>> PostCkmopIivolaPorteo(CkmopIivolaPorteoModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateCkmopIivolaPorteo(model, userName);
            return CreatedAtAction("GetCkmopIivolaPorteo", new { id = _model.IdCkmopIivolaPorteo }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CkmopIivolaPorteoModel>> DeleteCkmopIivolaPorteo(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadCkmopIivolaPorteo(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteCkmopIivolaPorteo(id, userName);

            return _model;
        }

    }
}