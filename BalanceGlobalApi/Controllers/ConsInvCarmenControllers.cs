
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
    public class ConsInvCarmenController : ControllerBase
    {
        private readonly IConsInvCarmenService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ConsInvCarmenController(IConsInvCarmenService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ConsInvCarmenModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetConsInvCarmenByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadConsInvCarmenByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsInvCarmenModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetConsInvCarmen(int id)
        {
            var _model = await _service.ReadConsInvCarmen(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsInvCarmenModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutConsInvCarmen(int id, ConsInvCarmenModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsInvCarmen)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateConsInvCarmen(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsInvCarmenModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostConsInvCarmen(ConsInvCarmenModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateConsInvCarmen(model, userName);
            var _model = _resp.Data as ConsInvCarmenModel;

            return _httpHelper.GetActionResult(_resp, "GetConsInvCarmen", new { id = _model?.IdConsInvCarmen });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsInvCarmenModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteConsInvCarmen(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteConsInvCarmen(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

