
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
    public class ImpregnacionCosechasController : ControllerBase
    {
        private readonly IImpregnacionCosechasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ImpregnacionCosechasController(IImpregnacionCosechasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ImpregnacionCosechasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetImpregnacionCosechasByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadImpregnacionCosechasByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImpregnacionCosechasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetImpregnacionCosechas(int id)
        {
            var _model = await _service.ReadImpregnacionCosechas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImpregnacionCosechasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutImpregnacionCosechas(int id, ImpregnacionCosechasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdImpregnacionCosechas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateImpregnacionCosechas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImpregnacionCosechasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostImpregnacionCosechas(ImpregnacionCosechasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateImpregnacionCosechas(model, userName);
            var _model = _resp.Data as ImpregnacionCosechasModel;

            return _httpHelper.GetActionResult(_resp, "GetImpregnacionCosechas", new { id = _model?.IdImpregnacionCosechas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ImpregnacionCosechasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteImpregnacionCosechas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteImpregnacionCosechas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

