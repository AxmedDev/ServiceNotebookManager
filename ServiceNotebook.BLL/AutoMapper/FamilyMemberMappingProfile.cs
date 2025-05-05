using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ServiceNotebook.BLL.DTOs.FamilyMember;
using ServiceNotebook.Core.Entities;

namespace ServiceNotebook.BLL.AutoMapper
{
    internal class FamilyMemberMappingProfile : Profile
    {
        public FamilyMemberMappingProfile()
        {
            CreateMap<FamilyMember,FamilyMemberDTO>().ReverseMap();
            CreateMap<FamilyMemberCreateDTO,FamilyMember>().ReverseMap();
        }
    }
}
