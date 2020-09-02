using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BalanceGlobal.Database.Tables;
using BalanceGlobal.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BalanceGlobal.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SubSistemasController : ControllerBase
    {
        private readonly IService _service;

        public SubSistemasController(IService service )
        {
            _service = service;
        }
        // GET: api/<SubSistemasController>
        [HttpGet]
        public async Task<IEnumerable<Subsistemas>> GetAll()
        {
            return await _service.GetSubSistemas();
        }

        // GET api/<SubSistemasController>/5
        // [HttpGet("{id}")]
        // public IEnumerable<Subsistemas> Get(int id)
        // {
        //     return _service.GetSubSistemas();
        // }

        // POST api/<SubSistemasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SubSistemasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SubSistemasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
