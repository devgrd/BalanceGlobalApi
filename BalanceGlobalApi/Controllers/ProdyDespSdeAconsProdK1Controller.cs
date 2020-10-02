
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
    public class ProdyDespSdeAconsProdK1Controller : ControllerBase
    {
        private readonly IProdyDespSdeAconsProdK1Service _service;

        public ProdyDespSdeAconsProdK1Controller(IProdyDespSdeAconsProdK1Service service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdyDespSdeAconsProdK1Model>>> GetProdyDespSdeAconsProdK1()
        {
            return await _service.ReadProdyDespSdeAconsProdK1();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdyDespSdeAconsProdK1Model>> GetProdyDespSdeAconsProdK1(int id)
        {
            var _model = await _service.ReadProdyDespSdeAconsProdK1(id);

            if (_model == null)
            {
                return NotFound();
            }

            return _model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProdyDespSdeAconsProdK1(int id, ProdyDespSdeAconsProdK1Model model, [Required][FromHeader] string userName)
        {
            if (id != model.IdProdyDespSdeAconsProdK1)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateProdyDespSdeAconsProdK1(model, userName);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_service.ReadProdyDespSdeAconsProdK1(id) == null)
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
        public async Task<ActionResult<ProdyDespSdeAconsProdK1Model>> PostProdyDespSdeAconsProdK1(ProdyDespSdeAconsProdK1Model model, [Required][FromHeader] string userName)
        {
            var _model = await _service.CreateProdyDespSdeAconsProdK1(model, userName);
            return CreatedAtAction("GetProdyDespSdeAconsProdK1", new { id = _model.IdProdyDespSdeAconsProdK1 }, _model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ProdyDespSdeAconsProdK1Model>> DeleteProdyDespSdeAconsProdK1(int id, [Required][FromHeader] string userName)
        {
            var _model = await _service.ReadProdyDespSdeAconsProdK1(id);
            if (_model == null)
            {
                return NotFound();
            }

            await _service.DeleteProdyDespSdeAconsProdK1(id, userName);

            return _model;
        }

    }
}