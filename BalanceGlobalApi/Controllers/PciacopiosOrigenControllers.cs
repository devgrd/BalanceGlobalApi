
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
    public class PciacopiosOrigenController : ControllerBase
    {
        private readonly IPciacopiosOrigenService _service;
        private readonly HttpCodeHelper _httpHelper;

        public PciacopiosOrigenController(IPciacopiosOrigenService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<PciacopiosOrigenModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetPciacopiosOrigen()
        {
            return await _service.ReadPciacopiosOrigen();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PciacopiosOrigenModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetPciacopiosOrigen(int id)
        {
            var _model = await _service.ReadPciacopiosOrigen(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PciacopiosOrigenModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutPciacopiosOrigen(int id, PciacopiosOrigenModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdPciacopiosOrigen)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdatePciacopiosOrigen(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PciacopiosOrigenModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostPciacopiosOrigen(PciacopiosOrigenModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreatePciacopiosOrigen(model, userName);
            var _model = _resp.Data as PciacopiosOrigenModel;

            return _httpHelper.GetActionResult(_resp, "GetPciacopiosOrigen", new { id = _model?.IdPciacopiosOrigen });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<PciacopiosOrigenModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeletePciacopiosOrigen(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeletePciacopiosOrigen(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

