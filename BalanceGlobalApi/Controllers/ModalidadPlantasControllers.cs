
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
    public class ModalidadPlantasController : ControllerBase
    {
        private readonly IModalidadPlantasService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ModalidadPlantasController(IModalidadPlantasService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ModalidadPlantasModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetModalidadPlantas()
        {
            return await _service.ReadModalidadPlantas();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ModalidadPlantasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetModalidadPlantas(int id)
        {
            var _model = await _service.ReadModalidadPlantas(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ModalidadPlantasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutModalidadPlantas(int id, ModalidadPlantasModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdModalidadPlantas)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateModalidadPlantas(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ModalidadPlantasModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostModalidadPlantas(ModalidadPlantasModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateModalidadPlantas(model, userName);
            var _model = _resp.Data as ModalidadPlantasModel;

            return _httpHelper.GetActionResult(_resp, "GetModalidadPlantas", new { id = _model?.IdModalidadPlantas });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ModalidadPlantasModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteModalidadPlantas(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteModalidadPlantas(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

