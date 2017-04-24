using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Employees.Models;
// using System.

namespace Employees.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        IEmployeeRepository _content; // = new IEmployeeRepository();

        public EmployeeController(IEmployeeRepository repository)
        {
            // IEmployeeRepository _content;
            _content = repository;
        }
        // GET api/employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _content.GetAll();
        }

        // GET api/employee/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/employee
        [HttpPost]
        public void Post([FromBody]Employee Emp)
        {
            _content.Add(Emp);
            // var response = new HttpRes
        }

        // PUT api/employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/employee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
