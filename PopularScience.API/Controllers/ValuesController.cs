using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.Repository;
using Domain.DBModels;
using Microsoft.AspNetCore.Mvc;

namespace PopularScience.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IUserRepository UserRepository;
        public ValuesController(IUserRepository UserRepository)
        {
            this.UserRepository = UserRepository;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return UserRepository.FindAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
