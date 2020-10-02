
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
    public class CorrienteLi2Co3Controller : ControllerBase
    {
        private readonly ICorrienteLi2Co3Service _service;

        public CorrienteLi2Co3Controller(ICorrienteLi2Co3Service service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CorrienteLi2Co3Model>>> GetCorrienteLi2Co3()
        {
            return await _service.ReadCorrienteLi2Co3();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CorrienteLi2Co3Model>> GetCorrienteLi2Co3(int id)
        {
            var _model = await _service.ReadCorrienteLi2Co3(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCorrienteLi2Co3(int id, CorrienteLi2Co3Model model, [Required][FromHeader] string userName)
        {
            if (id != model.IdCorrienteLi2Co3)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateCorrienteLi2Co3(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadCorrienteLi2Co3(id) == null)
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
        public async Task<ActionResult<CorrienteLi2Co3Model>> PostCorrienteLi2Co3(CorrienteLi2Co3Model model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateCorrienteLi2Co3(model, userName);
            return CreatedAtAction("GetCorrienteLi2Co3", new { id = _model.IdCorrienteLi2Co3 }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CorrienteLi2Co3Model>> DeleteCorrienteLi2Co3(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadCorrienteLi2Co3(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteCorrienteLi2Co3(id, userName);

            return _model;
        }

    }
}