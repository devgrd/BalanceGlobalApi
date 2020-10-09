
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
    public class ConsLi2Co3Controller : ControllerBase
    {
        private readonly IConsLi2Co3Service _service;
        private readonly HttpCodeHelper _httpHelper;

        public ConsLi2Co3Controller(IConsLi2Co3Service service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ConsLi2Co3Model>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetConsLi2Co3()
        {
            return await _service.ReadConsLi2Co3();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsLi2Co3Model>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetConsLi2Co3(int id)
        {
            var _model = await _service.ReadConsLi2Co3(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsLi2Co3Model>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutConsLi2Co3(int id, ConsLi2Co3Model model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsLi2Co3)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateConsLi2Co3(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsLi2Co3Model>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostConsLi2Co3(ConsLi2Co3Model model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateConsLi2Co3(model, userName);
            var _model = _resp.Data as ConsLi2Co3Model;

            return _httpHelper.GetActionResult(_resp, "GetConsLi2Co3", new { id = _model?.IdConsLi2Co3 });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsLi2Co3Model>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteConsLi2Co3(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteConsLi2Co3(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

