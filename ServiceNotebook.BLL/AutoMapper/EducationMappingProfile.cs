using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ServiceNotebook.BLL.DTOs.Education;
using ServiceNotebook.Core.Entities;

namespace ServiceNotebook.BLL.AutoMapper
{
    public class EducationMappingProfile: Profile
    {
        public EducationMappingProfile()
        {
            CreateMap<EducationCreateDTO, Education>();
            CreateMap<Education, EducationDTO>();
            CreateMap<EducationUpdateDTO, Education>().ReverseMap();

            CreateMap<Education, EducationDTO>()
                .ForMember(dest => dest.Employee, opt => opt.MapFrom(src => src.EmployeeNotebook)) // Burada çevirmə aparılır
                .ReverseMap();
        }
        

    }
}
