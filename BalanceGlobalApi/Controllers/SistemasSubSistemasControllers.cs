
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
    public class SistemasSubSistemasController : ControllerBase
    {
        private readonly ISistemasSubSistemasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public SistemasSubSistemasController(ISistemasSubSistemasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<SistemasSubSistemasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetSistemasSubSistemas()
        {
            return await _service.ReadSistemasSubSistemas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SistemasSubSistemasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetSistemasSubSistemas(int id)
        {
            var _model = await _service.ReadSistemasSubSistemas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SistemasSubSistemasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutSistemasSubSistemas(int id, SistemasSubSistemasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdSistemasSubsistemas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateSistemasSubSistemas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SistemasSubSistemasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostSistemasSubSistemas(SistemasSubSistemasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateSistemasSubSistemas(model, userName);
            var _model = _resp.Data as SistemasSubSistemasModel;

            return _httpHelper.GetActionResult(_resp, "GetSistemasSubSistemas", new { id = _model?.IdSistemasSubsistemas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SistemasSubSistemasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteSistemasSubSistemas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteSistemasSubSistemas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

