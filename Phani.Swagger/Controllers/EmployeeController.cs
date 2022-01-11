using Microsoft.AspNetCore.Mvc;
using Phani.Swagger.Models;
using System.Collections.Generic;

namespace Phani.Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/Employee
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return GetEmployees();
        }

        // GET: api/Employee/1
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            return GetEmployees().Find(e => e.Id == id);
        }

        // POST: api/Employee
        [HttpPost]
        [Produces("application/json")]
        public Employee Post([FromBody] Employee employee)
        {
            return new Employee();
        }

        // PUT: api/Employee/1
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee employee)
        {
        }

        // DELETE: api/Employee/1
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name= "Phani",
                    Description = "Developer"
                },
                new Employee()
                {
                    Id = 2,
                    Name= "Phani T",
                    Description = "Tester"
                }
            };
        }
    }
}
