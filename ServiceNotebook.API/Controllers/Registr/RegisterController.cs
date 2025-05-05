using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using ServiceNotebook.BLL.DTOs.User;
using ServiceNotebook.BLL.Services;
using ServiceNotebook.BLL.Services.TokenService;
using ServiceNotebook.Core.Entities.Register;

namespace ServiceNotebook.API.Controllers.Registr
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly UserService service;
        private TokenService tokenService;

        public RegisterController(TokenService tokenService, UserService service)
        {
            this.service = service;
            this.tokenService = tokenService;

        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllUserAsync()
        {
            return Ok(await service.GetUsersAsync());
        }


        [HttpPost ("Login")]
        public async Task<IActionResult> LoginAsync(UserCreateDTO userCreateDTO)
        {
           User? user= await service.ValidateUser(userCreateDTO.UserName, userCreateDTO.PasswordHash);
            if (user == null)
            {
                return BadRequest();
            }
            string  token=tokenService.GenerateToken(user);
            return Ok(token);
        }

        [HttpPost]
        public async Task RegisterAsync(UserCreateDTO userCreateDTO)
        {
           await service.RegisterUserAsync(userCreateDTO);
        }
    }
}
