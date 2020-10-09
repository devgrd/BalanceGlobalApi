
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
    public class SubSistemasController : ControllerBase
    {
        private readonly ISubSistemasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public SubSistemasController(ISubSistemasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<SubSistemasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetSubSistemas()
        {
            return await _service.ReadSubSistemas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SubSistemasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetSubSistemas(int id)
        {
            var _model = await _service.ReadSubSistemas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SubSistemasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutSubSistemas(int id, SubSistemasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdSubSistemas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateSubSistemas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SubSistemasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostSubSistemas(SubSistemasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateSubSistemas(model, userName);
            var _model = _resp.Data as SubSistemasModel;

            return _httpHelper.GetActionResult(_resp, "GetSubSistemas", new { id = _model?.IdSubSistemas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<SubSistemasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteSubSistemas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteSubSistemas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

