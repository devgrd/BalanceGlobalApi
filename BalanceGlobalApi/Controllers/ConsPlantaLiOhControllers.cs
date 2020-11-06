
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
    public class ConsPlantaLiOhController : ControllerBase
    {
        private readonly IConsPlantaLiOhService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ConsPlantaLiOhController(IConsPlantaLiOhService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ConsPlantaLiOhModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetConsPlantaLiOhByPeriodos([Required][FromQuery] int IdPeriodo)
        {
            return await _service.ReadConsPlantaLiOhByPeriodos(IdPeriodo);
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsPlantaLiOhModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetConsPlantaLiOh(int id)
        {
            var _model = await _service.ReadConsPlantaLiOh(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsPlantaLiOhModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutConsPlantaLiOh(int id, ConsPlantaLiOhModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdConsPlantaLiOh)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateConsPlantaLiOh(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsPlantaLiOhModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostConsPlantaLiOh(ConsPlantaLiOhModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateConsPlantaLiOh(model, userName);
            var _model = _resp.Data as ConsPlantaLiOhModel;

            return _httpHelper.GetActionResult(_resp, "GetConsPlantaLiOh", new { id = _model?.IdConsPlantaLiOh });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ConsPlantaLiOhModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteConsPlantaLiOh(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteConsPlantaLiOh(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

