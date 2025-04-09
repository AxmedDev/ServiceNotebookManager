using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ServiceNotebook.BLL.DTOs.Education;
using ServiceNotebook.BLL.DTOs.Employee;
using ServiceNotebook.BLL.Models.Employee;
using ServiceNotebook.Core.Entities;

namespace ServiceNotebook.BLL.AutoMapper
{
    public  class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeNotebook, EmployeeNotebookDTO>().ReverseMap();
            CreateMap<EmployeeNotebook, EmployeeNotebookCreateDTO>().ReverseMap();
            CreateMap<Education,EducationCreateDTO>().ReverseMap();
            CreateMap<Education, EducationDTO>().ReverseMap();

            CreateMap<Education, EducationDTO>()
            .ForMember(dest => dest.Employee, opt => opt.MapFrom(src => src.EmployeeNotebook)) // Burada çevirmə aparılır
            .ReverseMap();

        }

    }
}
