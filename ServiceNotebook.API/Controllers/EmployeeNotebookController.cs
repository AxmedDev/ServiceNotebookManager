using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceNotebook.BLL.DTOs.Employee;
using ServiceNotebook.BLL.Models.Employee;
using ServiceNotebook.BLL.Services;

namespace ServiceNotebook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeNotebookController : ControllerBase
    {
        private readonly EmployeeNotebookServices services;
        public EmployeeNotebookController(EmployeeNotebookServices services)
        {
            this.services = services;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeeAsync()
        {

            return Ok(await services.GetEmployesAsync());
        }

        [HttpPost ("Insert Employee")]
        public async Task<IActionResult> InsertEmployeeAsync([FromForm] EmployeeNotebookCreateDTO employeeNotebookCreateDTO)
        {
            await services.InsertEmployeeAsync(employeeNotebookCreateDTO);
            return Ok();
        }

        [HttpDelete("Remove Employee")]
        public async Task<IActionResult> RemoveEmployeeAsync(int Id)
        {
           bool result =await services.RemoveEmployeeAsync(Id);
            if (result) return Ok();
            return BadRequest();
        }

        [HttpPatch("Update Employee")]
        public async Task<IActionResult> UpdateEmployeeAsync(EmployeeNotebookUpdateDTO employeeNotebookUpdateDTO)
        {
            bool result = await services.UpdateEmployeeAsync(employeeNotebookUpdateDTO);
            if (result) return Ok();
            return BadRequest();
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetEmployeeByIdAsync(int Id)
        {
         
          return Ok(await services.GetEmployeeByIdAsync(Id));
        }

    }
}
