
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
    public class PciacopiosCliController : ControllerBase
    {
        private readonly IPciacopiosCliService _service;
        private readonly HttpCodeHelper _httpHelper;

        public PciacopiosCliController(IPciacopiosCliService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<PciacopiosCliModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetPciacopiosCliByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadPciacopiosCliByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PciacopiosCliModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetPciacopiosCli(int id)
        {
            var _model = await _service.ReadPciacopiosCli(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PciacopiosCliModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutPciacopiosCli(int id, PciacopiosCliModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPciacopiosCli)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdatePciacopiosCli(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PciacopiosCliModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostPciacopiosCli(PciacopiosCliModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreatePciacopiosCli(model, userName);
            var _model = _resp.Data as PciacopiosCliModel;

            return _httpHelper.GetActionResult(_resp, "GetPciacopiosCli", new { id = _model?.IdPciacopiosCli });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PciacopiosCliModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeletePciacopiosCli(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeletePciacopiosCli(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

