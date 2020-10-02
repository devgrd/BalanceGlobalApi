
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
    public class ImpregnacionCosechasController : ControllerBase
    {
        private readonly IImpregnacionCosechasService _service;

        public ImpregnacionCosechasController(IImpregnacionCosechasService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImpregnacionCosechasModel>>> GetImpregnacionCosechas()
        {
            return await _service.ReadImpregnacionCosechas();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ImpregnacionCosechasModel>> GetImpregnacionCosechas(int id)
        {
            var _model = await _service.ReadImpregnacionCosechas(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutImpregnacionCosechas(int id, ImpregnacionCosechasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImpregnacionCosechas)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateImpregnacionCosechas(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadImpregnacionCosechas(id) == null)
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
        public async Task<ActionResult<ImpregnacionCosechasModel>> PostImpregnacionCosechas(ImpregnacionCosechasModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateImpregnacionCosechas(model, userName);
            return CreatedAtAction("GetImpregnacionCosechas", new { id = _model.IdImpregnacionCosechas }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ImpregnacionCosechasModel>> DeleteImpregnacionCosechas(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadImpregnacionCosechas(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteImpregnacionCosechas(id, userName);

            return _model;
        }

    }
}