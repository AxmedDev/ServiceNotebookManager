using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceNotebook.BLL.DTOs.Education;
using ServiceNotebook.BLL.Services;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        private readonly EducationService service;
        public EducationController(EducationService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> InsertEducationAsync([FromForm]EducationCreateDTO educationCreateDTO)
        {
            await service.InsertEducationAsync(educationCreateDTO);
            return Ok(educationCreateDTO);
        }

        [HttpGet ("{EmployeeId}")]
        public async Task<IEnumerable<EducationDTO>> GetEducationWithEmployeeIdAsync(int EmployeeId)
        {
            return await service.GetEducationsWithEmployeeIdAsync(EmployeeId);
        }

       
    }
}
