
using BalanceGlobal.Api.Helper;
using BalanceGlobal.Models;
using BalanceGlobal.Response;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.Annotations;
using System;

namespace BalanceGlobal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangeTrackingHeaderController : ControllerBase
    {
        private readonly IChangeTrackingHeaderService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ChangeTrackingHeaderController(IChangeTrackingHeaderService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ChangeTrackingHeaderModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetChangeTrackingHeader([FromQuery][Required] string table, [FromQuery][Required] DateTime from, [FromQuery][Required] DateTime to)
        {
            return await _service.ReadChangeTrackingHeader(table, from, to);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ChangeTrackingHeaderModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetChangeTrackingHeader(int id)
        {
            var _model = await _service.ReadChangeTrackingHeader(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ChangeTrackingHeaderModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutChangeTrackingHeader(int id, ChangeTrackingHeaderModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdChangeTrackingHeader)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateChangeTrackingHeader(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ChangeTrackingHeaderModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostChangeTrackingHeader(ChangeTrackingHeaderModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateChangeTrackingHeader(model, userName);
            var _model = _resp.Data as ChangeTrackingHeaderModel;

            return _httpHelper.GetActionResult(_resp, "GetChangeTrackingHeader", new { id = _model?.IdChangeTrackingHeader });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ChangeTrackingHeaderModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteChangeTrackingHeader(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteChangeTrackingHeader(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

