
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
    public class ImpregnacionSistemaRefController : ControllerBase
    {
        private readonly IImpregnacionSistemaRefService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ImpregnacionSistemaRefController(IImpregnacionSistemaRefService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ImpregnacionSistemaRefModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetImpregnacionSistemaRef()
        {
            return await _service.ReadImpregnacionSistemaRef();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImpregnacionSistemaRefModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetImpregnacionSistemaRef(int id)
        {
            var _model = await _service.ReadImpregnacionSistemaRef(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImpregnacionSistemaRefModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutImpregnacionSistemaRef(int id, ImpregnacionSistemaRefModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImpregnacionSistemaRef)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateImpregnacionSistemaRef(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImpregnacionSistemaRefModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostImpregnacionSistemaRef(ImpregnacionSistemaRefModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateImpregnacionSistemaRef(model, userName);
            var _model = _resp.Data as ImpregnacionSistemaRefModel;

            return _httpHelper.GetActionResult(_resp, "GetImpregnacionSistemaRef", new { id = _model?.IdImpregnacionSistemaRef });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImpregnacionSistemaRefModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteImpregnacionSistemaRef(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteImpregnacionSistemaRef(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

