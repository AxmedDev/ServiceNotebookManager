using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceNotebook.BLL.DTOs.FamilyMember;
using ServiceNotebook.BLL.Services;

namespace ServiceNotebook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyMemberController : ControllerBase
    {
        private readonly FamilyMemberService service;
        public FamilyMemberController(FamilyMemberService service)
        {
            this.service = service;
        }

        [HttpGet]

        public async Task<IActionResult> GetFamilyMemberAsync()
        {
            return Ok(await service.GetFamilyMemberAsync());
        }

        [HttpPost]
        public async Task<IActionResult> InsertFamilyMemberAsync([FromForm] FamilyMemberCreateDTO familyMemberCreateDTO)
        {

          await  service.InsertFamilyMemberAsync(familyMemberCreateDTO);
            return Ok();
        }
           

    }
}
