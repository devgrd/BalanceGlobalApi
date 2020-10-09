
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
    public class InfraestructurasController : ControllerBase
    {
        private readonly IInfraestructurasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public InfraestructurasController(IInfraestructurasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<InfraestructurasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetInfraestructuras()
        {
            return await _service.ReadInfraestructuras();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<InfraestructurasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetInfraestructuras(int id)
        {
            var _model = await _service.ReadInfraestructuras(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<InfraestructurasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutInfraestructuras(int id, InfraestructurasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdInfraestructuras)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateInfraestructuras(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<InfraestructurasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostInfraestructuras(InfraestructurasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateInfraestructuras(model, userName);
            var _model = _resp.Data as InfraestructurasModel;

            return _httpHelper.GetActionResult(_resp, "GetInfraestructuras", new { id = _model?.IdInfraestructuras });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<InfraestructurasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteInfraestructuras(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteInfraestructuras(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

