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

        [HttpPost("Insert Education")]
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


        [HttpDelete("Remove Employee")]
        public async Task<IActionResult> RemoveEducationAsync(int Id)
        {
            bool result = await service.RemoveEducationAsync(Id);
            if (result) return Ok();
            return BadRequest();
        }

        [HttpPatch("Update Education")]
        public async Task<IActionResult> UpdateEducationAsync([FromForm]EducationUpdateDTO educationUpdateDTO)
        {
          bool result= await  service.UpdateEducationAsync (educationUpdateDTO);
            if (result) return Ok();
                return BadRequest();
        }

        [HttpGet ("Get Educations")]
        public async Task<IActionResult> GetEducationAsync()
        {
            var educations= await service.GetEducationsAsync();
            return Ok(educations);

        }

    }
}
