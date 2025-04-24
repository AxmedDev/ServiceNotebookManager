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
    public  class EmployeeNotebookMappingProfile : Profile
    {
        public EmployeeNotebookMappingProfile()
        {
            CreateMap<EmployeeNotebook, EmployeeNotebookDTO>().ReverseMap();
            CreateMap<EmployeeNotebook, EmployeeNotebookCreateDTO>().ReverseMap();
            CreateMap<EmployeeNotebookUpdateDTO, EmployeeNotebook>();
        }

    }
}
