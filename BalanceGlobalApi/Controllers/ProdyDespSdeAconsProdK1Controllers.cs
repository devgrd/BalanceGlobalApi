
using BalanceGlobal.Api.Helper;
using BalanceGlobal.Models;
using BalanceGlobal.Response;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.Annotations;

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdyDespSdeAconsProdK1Controller : ControllerBase
    {
        private readonly IProdyDespSdeAconsProdK1Service _service;
        private readonly HttpCodeHelper _httpHelper;

        public ProdyDespSdeAconsProdK1Controller(IProdyDespSdeAconsProdK1Service service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ProdyDespSdeAconsProdK1Model>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetProdyDespSdeAconsProdK1()
        {
            return await _service.ReadProdyDespSdeAconsProdK1();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ProdyDespSdeAconsProdK1Model>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetProdyDespSdeAconsProdK1(int id)
        {
            var _model = await _service.ReadProdyDespSdeAconsProdK1(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ProdyDespSdeAconsProdK1Model>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutProdyDespSdeAconsProdK1(int id, ProdyDespSdeAconsProdK1Model model, [Required][FromHeader] string userName)
        {
            if (id != model.IdProdyDespSdeAconsProdK1)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateProdyDespSdeAconsProdK1(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ProdyDespSdeAconsProdK1Model>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostProdyDespSdeAconsProdK1(ProdyDespSdeAconsProdK1Model model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateProdyDespSdeAconsProdK1(model, userName);
            var _model = _resp.Data as ProdyDespSdeAconsProdK1Model;

            return _httpHelper.GetActionResult(_resp, "GetProdyDespSdeAconsProdK1", new { id = _model?.IdProdyDespSdeAconsProdK1 });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ProdyDespSdeAconsProdK1Model>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteProdyDespSdeAconsProdK1(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteProdyDespSdeAconsProdK1(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

