using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ServiceNotebook.BLL.DTOs.FamilyMember;
using ServiceNotebook.Core.Entities;
using ServiceNotebook.DAL.Repositories;

namespace ServiceNotebook.BLL.Services
{
    public  class FamilyMemberService
    {
        private readonly FamilyMemberRepository familyMemberRepository;
        private IMapper mapper;

        public FamilyMemberService(FamilyMemberRepository familyMemberRepository, IMapper mapper)
        {
            this.familyMemberRepository = familyMemberRepository;
            this.mapper = mapper;
        }

        public async Task<List<FamilyMemberDTO>> GetFamilyMemberAsync()
        {
           throw new NotImplementedException();
        }
    }
}
