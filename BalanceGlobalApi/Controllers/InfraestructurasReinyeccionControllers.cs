
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
    public class InfraestructurasReinyeccionController : ControllerBase
    {
        private readonly IInfraestructurasReinyeccionService _service;
        private readonly HttpCodeHelper _httpHelper;

        public InfraestructurasReinyeccionController(IInfraestructurasReinyeccionService service)
        {
            _service = service;
            _httpHelper = new HttpCodeHelper();
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<List<InfraestructurasReinyeccionModel>>))]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetInfraestructurasReinyeccion()
        {
            return await _service.ReadInfraestructurasReinyeccion();
        }

        [HttpGet("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<InfraestructurasReinyeccionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> GetInfraestructurasReinyeccion(int id)
        {
            var _model = await _service.ReadInfraestructurasReinyeccion(id);

            return _model;
        }

        [HttpPut("{id}")]
        [SwaggerResponse(200, "Ok", typeof(ApiResponse<InfraestructurasReinyeccionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        public async Task<ActionResult<ApiResponse>> PutInfraestructurasReinyeccion(int id, InfraestructurasReinyeccionModel model, [Required][FromHeader] string userName)
        {
            if (id != model.IdInfraestructurasReinyeccion)
            {
                return BadRequest(new ApiResponse("Bad Request", 400));
            }

            var _resp = await _service.UpdateInfraestructurasReinyeccion(model, userName);

            return _httpHelper.GetActionResult(_resp);
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<InfraestructurasReinyeccionModel>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> PostInfraestructurasReinyeccion(InfraestructurasReinyeccionModel model, [Required][FromHeader] string userName)
        {
            var _resp = await _service.CreateInfraestructurasReinyeccion(model, userName);
            var _model = _resp.Data as InfraestructurasReinyeccionModel;

            return _httpHelper.GetActionResult(_resp, "GetInfraestructurasReinyeccion", new { id = _model?.IdInfraestructurasReinyeccion });
        }

        [SwaggerResponse(200, "Ok", typeof(ApiResponse<InfraestructurasReinyeccionModel>))]
        [SwaggerResponse(404, "Not Found", typeof(ApiResponse<string>))]
        [SwaggerResponse(409, "Conflict", typeof(ApiResponse<string>))]
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse>> DeleteInfraestructurasReinyeccion(int id, [Required][FromHeader] string userName)
        {
            var _resp = await _service.DeleteInfraestructurasReinyeccion(id, userName);

            return _httpHelper.GetActionResult(_resp);
        }
    }
}

