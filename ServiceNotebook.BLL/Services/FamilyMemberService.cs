using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ServiceNotebook.BLL.DTOs.FamilyMember;
using ServiceNotebook.Core.Entities;
using ServiceNotebook.Core.Repositories;
using ServiceNotebook.DAL.Repositories;

namespace ServiceNotebook.BLL.Services
{
    public  class FamilyMemberService
    {
        private readonly IFamilyMemberRepository familyMemberRepository;
        private IMapper mapper;

        public FamilyMemberService(IFamilyMemberRepository familyMemberRepository, IMapper mapper)
        {
            this.familyMemberRepository = familyMemberRepository;
            this.mapper = mapper;
        }

        public async Task<List<FamilyMemberDTO>> GetFamilyMemberAsync()
        {
            return  mapper.Map<List<FamilyMemberDTO>>(await familyMemberRepository.GetAllAsync());
        }


        public async Task InsertFamilyMemberAsync(FamilyMemberCreateDTO familMemberCreateDTO)
        {
            await familyMemberRepository.AddAsync(mapper.Map<FamilyMember>(familMemberCreateDTO));
        }
    }
}
