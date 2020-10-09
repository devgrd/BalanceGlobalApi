
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
    public class TipoSalController : ControllerBase
    {
        private readonly ITipoSalService _service;
        private readonly HttpCodeHelper _httpHelper;

        public TipoSalController(ITipoSalService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<TipoSalModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetTipoSal()
        {
            return await _service.ReadTipoSal();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoSalModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetTipoSal(int id)
        {
            var _model = await _service.ReadTipoSal(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoSalModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutTipoSal(int id, TipoSalModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdTipoSal)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateTipoSal(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoSalModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostTipoSal(TipoSalModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateTipoSal(model, userName);
            var _model = _resp.Data as TipoSalModel;

            return _httpHelper.GetActionResult(_resp, "GetTipoSal", new { id = _model?.IdTipoSal });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<TipoSalModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteTipoSal(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteTipoSal(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

