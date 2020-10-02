
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
    public class ProdyDespSdeAconsProdKController : ControllerBase
    {
        private readonly IProdyDespSdeAconsProdKService _service;

        public ProdyDespSdeAconsProdKController(IProdyDespSdeAconsProdKService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdyDespSdeAconsProdKModel>>> GetProdyDespSdeAconsProdK()
        {
            return await _service.ReadProdyDespSdeAconsProdK();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdyDespSdeAconsProdKModel>> GetProdyDespSdeAconsProdK(int id)
        {
            var _model = await _service.ReadProdyDespSdeAconsProdK(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProdyDespSdeAconsProdK(int id, ProdyDespSdeAconsProdKModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdProdyDespSdeAconsProdK)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateProdyDespSdeAconsProdK(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadProdyDespSdeAconsProdK(id) == null)
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
        public async Task<ActionResult<ProdyDespSdeAconsProdKModel>> PostProdyDespSdeAconsProdK(ProdyDespSdeAconsProdKModel model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateProdyDespSdeAconsProdK(model, userName);
            return CreatedAtAction("GetProdyDespSdeAconsProdK", new { id = _model.IdProdyDespSdeAconsProdK }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ProdyDespSdeAconsProdKModel>> DeleteProdyDespSdeAconsProdK(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadProdyDespSdeAconsProdK(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteProdyDespSdeAconsProdK(id, userName);

            return _model;
        }

    }
}