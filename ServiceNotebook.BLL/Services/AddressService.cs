using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ServiceNotebook.BLL.DTOs.Address;
using ServiceNotebook.Core.Entities;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.BLL.Services
{
    public class AddressService
    {
        private readonly IMapper mapper;
        private readonly IAddressRepository addressRepository;
        public AddressService(IMapper mapper, IAddressRepository addressRepository)
        {
            this.mapper = mapper;
            this.addressRepository = addressRepository;      
        }

        public async Task<List<AddressDTO>> GetAddressesAsync()
        {
           
            return  mapper.Map<List<AddressDTO>>(await addressRepository.GetAllAsync());
           
        }

        public async Task InsertAddressAsync(AddressCreateDTO addressCreateDTO)
        {
            await addressRepository.AddAsync(mapper.Map<Address>(addressCreateDTO));
        }

        public async Task<List<AddressWithEmployeeDTO>> GetAddressesWithEmployeeIdAsync(int EmployeeId)
        {
          return  mapper.Map<List<AddressWithEmployeeDTO>>(await addressRepository.GetAddressesWithEmployeeIdAsync(EmployeeId));

        }

        public async Task<bool> RemoveAddressAsync(int AddressId)
        {
           bool result= await  addressRepository.DeleteAsync(AddressId);
           return result;  

        }

        public async Task<bool> UpdateAddressAsync(AddressUpdateDTO addressUpdateDTO)
        {
            bool result = await addressRepository.UpdateAsync(mapper.Map<Address>(addressUpdateDTO));
            return result;
        }

       
        

    }
}
