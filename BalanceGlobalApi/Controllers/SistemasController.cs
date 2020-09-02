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
    public class SistemasController : ControllerBase
    {
        private readonly IService _service;
        public SistemasController(IService service)
        {
            _service = service;
        }

        // GET: api/<SistemasController>
        [HttpGet]
        public async Task<IEnumerable<Sistemas>> Get()
        {
            return await _service.GetSistemas();
        }

        // GET api/<SistemasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SistemasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SistemasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SistemasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
