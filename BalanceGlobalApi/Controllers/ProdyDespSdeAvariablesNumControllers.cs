
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
    public class ProdyDespSdeAvariablesNumController : ControllerBase
    {
        private readonly IProdyDespSdeAvariablesNumService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ProdyDespSdeAvariablesNumController(IProdyDespSdeAvariablesNumService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ProdyDespSdeAvariablesNumModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetProdyDespSdeAvariablesNum()
        {
            return await _service.ReadProdyDespSdeAvariablesNum();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ProdyDespSdeAvariablesNumModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetProdyDespSdeAvariablesNum(int id)
        {
            var _model = await _service.ReadProdyDespSdeAvariablesNum(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ProdyDespSdeAvariablesNumModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutProdyDespSdeAvariablesNum(int id, ProdyDespSdeAvariablesNumModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdProdyDespSdeAvariablesNum)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateProdyDespSdeAvariablesNum(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ProdyDespSdeAvariablesNumModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostProdyDespSdeAvariablesNum(ProdyDespSdeAvariablesNumModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateProdyDespSdeAvariablesNum(model, userName);
            var _model = _resp.Data as ProdyDespSdeAvariablesNumModel;

            return _httpHelper.GetActionResult(_resp, "GetProdyDespSdeAvariablesNum", new { id = _model?.IdProdyDespSdeAvariablesNum });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ProdyDespSdeAvariablesNumModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteProdyDespSdeAvariablesNum(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteProdyDespSdeAvariablesNum(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

