using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceNotebook.BLL.DTOs.Employee;
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

        [HttpPost]
        public async Task<IActionResult> InsertEmployeeAsync([FromForm] EmployeeNotebookCreateDTO employeeNotebookCreateDTO)
        {
            await services.InsertEmployeeAsync(employeeNotebookCreateDTO);
            return Ok();
        }


    }
}
