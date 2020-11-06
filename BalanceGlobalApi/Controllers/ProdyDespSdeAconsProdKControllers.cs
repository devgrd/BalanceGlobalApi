
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
    public class ProdyDespSdeAconsProdKController : ControllerBase
    {
        private readonly IProdyDespSdeAconsProdKService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ProdyDespSdeAconsProdKController(IProdyDespSdeAconsProdKService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ProdyDespSdeAconsProdKModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetProdyDespSdeAconsProdKByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadProdyDespSdeAconsProdKByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ProdyDespSdeAconsProdKModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetProdyDespSdeAconsProdK(int id)
        {
            var _model = await _service.ReadProdyDespSdeAconsProdK(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ProdyDespSdeAconsProdKModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutProdyDespSdeAconsProdK(int id, ProdyDespSdeAconsProdKModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdProdyDespSdeAconsProdK)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateProdyDespSdeAconsProdK(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ProdyDespSdeAconsProdKModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostProdyDespSdeAconsProdK(ProdyDespSdeAconsProdKModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateProdyDespSdeAconsProdK(model, userName);
            var _model = _resp.Data as ProdyDespSdeAconsProdKModel;

            return _httpHelper.GetActionResult(_resp, "GetProdyDespSdeAconsProdK", new { id = _model?.IdProdyDespSdeAconsProdK });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ProdyDespSdeAconsProdKModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteProdyDespSdeAconsProdK(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteProdyDespSdeAconsProdK(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

