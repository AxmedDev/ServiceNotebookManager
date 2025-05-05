using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ServiceNotebook.BLL.DTOs.User;
using ServiceNotebook.Core.Entities.Register;

namespace ServiceNotebook.BLL.AutoMapper
{
    public  class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<UserCreateDTO, User>().ReverseMap();
        }
    }
}
