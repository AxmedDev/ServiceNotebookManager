using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceNotebook.BLL.DTOs.Address;
using ServiceNotebook.BLL.Services;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly AddressService service;
        public AddressController(AddressService service)
        {
            this.service = service;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAddressesAsync()
        {
            return Ok(await service.GetAddressesAsync());
        }

        [HttpPost]
        public async Task<IActionResult> InsertAdressAsync(AddressCreateDTO addressCreateDTO)
        {
            await service.InsertAddressAsync(addressCreateDTO);
            return Ok();
        }

        [HttpGet("{EmployeeId}")]
        public async Task<IActionResult> GetAddressWithEmployeeId(int EmployeeId)
        {
            return Ok(await service.GetAddressesWithEmployeeIdAsync(EmployeeId));
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateAddressAsync(AddressUpdateDTO addressUpdateDTO)
        {
           bool result = await service.UpdateAddressAsync(addressUpdateDTO);
            if (result)  return Ok();
            return BadRequest();
        }

       
    }
}
