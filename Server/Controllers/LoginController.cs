using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Server.Data;
using RegistrationForm.Shared;

namespace RegistrationForm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly EmployeeDbContext _context;
        public LoginController(EmployeeDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("addemp")]
        public async Task<ActionResult<Employee>> AddEmployee([FromBody] Employee employee)
        {
            if (employee != null)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return CreatedAtAction(nameof(AddEmployee), employee); // Return CreatedAtAction on success
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
