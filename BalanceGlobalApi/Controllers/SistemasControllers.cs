
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
    public class SistemasController : ControllerBase
    {
        private readonly ISistemasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public SistemasController(ISistemasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<SistemasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetSistemas()
        {
            return await _service.ReadSistemas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SistemasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetSistemas(int id)
        {
            var _model = await _service.ReadSistemas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SistemasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutSistemas(int id, SistemasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdSistemas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateSistemas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SistemasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostSistemas(SistemasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateSistemas(model, userName);
            var _model = _resp.Data as SistemasModel;

            return _httpHelper.GetActionResult(_resp, "GetSistemas", new { id = _model?.IdSistemas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SistemasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteSistemas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteSistemas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

