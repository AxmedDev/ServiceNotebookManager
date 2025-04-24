using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ServiceNotebook.BLL.DTOs.Address;
using ServiceNotebook.BLL.DTOs.Education;
using ServiceNotebook.Core.Entities;

namespace ServiceNotebook.BLL.AutoMapper
{
    public  class AddressMappingProfile : Profile
    {
        public AddressMappingProfile()
        {
            CreateMap<Address, AddressDTO>();
            CreateMap<AddressCreateDTO, Address>();
            CreateMap<AddressUpdateDTO, Address>();

            CreateMap<Address, AddressWithEmployeeDTO>()
                .ForMember(dest => dest.Employee, opt => opt.MapFrom(src => src.EmployeeNotebook)) 
                .ReverseMap();
        }
    }
}
