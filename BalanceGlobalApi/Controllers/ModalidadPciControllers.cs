
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
    public class ModalidadPciController : ControllerBase
    {
        private readonly IModalidadPciService _service;
        private readonly HttpCodeHelper _httpHelper;

        public ModalidadPciController(IModalidadPciService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<ModalidadPciModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetModalidadPci()
        {
            return await _service.ReadModalidadPci();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ModalidadPciModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetModalidadPci(int id)
        {
            var _model = await _service.ReadModalidadPci(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ModalidadPciModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutModalidadPci(int id, ModalidadPciModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdModalidadPci)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateModalidadPci(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ModalidadPciModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostModalidadPci(ModalidadPciModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateModalidadPci(model, userName);
            var _model = _resp.Data as ModalidadPciModel;

            return _httpHelper.GetActionResult(_resp, "GetModalidadPci", new { id = _model?.IdModalidadPci });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<ModalidadPciModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteModalidadPci(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteModalidadPci(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

