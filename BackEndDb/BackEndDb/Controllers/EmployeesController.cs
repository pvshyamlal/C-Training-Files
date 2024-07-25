using Microsoft.AspNetCore.Mvc;
using BackEndDb.Model;
using BackEndDb.Model.Entities;
using Microsoft.AspNetCore.Http;
using BackEndDb.Data;

namespace BackEndDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext DbContext;
        public EmployeesController(ApplicationDbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(DbContext.Employees.ToList());
        }
        [HttpGet]
        [Route("id:guid")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var employee = DbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
            }

        [HttpPost]
        public IActionResult AddEmployees(AddEmployeeDto addEmployee)
        {
           var employeeEntity = new Employee()
            {
                Name = addEmployee.Name,
                Email = addEmployee.Email,
                Phone = addEmployee.Phone,
                Salary = addEmployee.Salary
            };
            DbContext.Employees.Add(employeeEntity);
            DbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPut]
        [Route("id:guid")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployee)
        {
            var employee = DbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            employee.Name = updateEmployee.Name;
            employee.Email = updateEmployee.Email;
            employee.Phone = updateEmployee.Phone;
            employee.Salary = updateEmployee.Salary;
            DbContext.SaveChanges();
            return Ok(employee);
        }
        [HttpDelete]
        [Route("id:guid")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = DbContext.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            DbContext.Employees.Remove(employee);
            DbContext.SaveChanges();
            return Ok();
        }
    }
}
