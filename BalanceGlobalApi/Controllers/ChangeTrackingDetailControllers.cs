
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
    public class ChangeTrackingDetailController : ControllerBase
    {
        private readonly IChangeTrackingDetailService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ChangeTrackingDetailController(IChangeTrackingDetailService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ChangeTrackingDetailModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetChangeTrackingDetail()
        {
            return await _service.ReadChangeTrackingDetail();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ChangeTrackingDetailModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetChangeTrackingDetail(int id)
        {
            var _model = await _service.ReadChangeTrackingDetail(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ChangeTrackingDetailModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutChangeTrackingDetail(int id, ChangeTrackingDetailModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdChangeTrackingDetail)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateChangeTrackingDetail(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ChangeTrackingDetailModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostChangeTrackingDetail(ChangeTrackingDetailModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateChangeTrackingDetail(model, userName);
            var _model = _resp.Data as ChangeTrackingDetailModel;

            return _httpHelper.GetActionResult(_resp, "GetChangeTrackingDetail", new { id = _model?.IdChangeTrackingDetail });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ChangeTrackingDetailModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteChangeTrackingDetail(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteChangeTrackingDetail(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

