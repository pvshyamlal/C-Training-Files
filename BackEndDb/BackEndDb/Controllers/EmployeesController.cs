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
    }
}
