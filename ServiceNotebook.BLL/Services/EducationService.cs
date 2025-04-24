using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ServiceNotebook.BLL.DTOs.Education;
using ServiceNotebook.Core.Entities;
using ServiceNotebook.Core.Repositories;
using ServiceNotebook.DAL.Repositories;

namespace ServiceNotebook.BLL.Services
{
    public class EducationService
    {
        private readonly IMapper mapper;
        private readonly IEducationRepository educationRepository;
        public EducationService(IEducationRepository educationRepository, IMapper mapper)
        {
            this.educationRepository = educationRepository;
            this.mapper = mapper;
        }

        public async Task InsertEducationAsync(EducationCreateDTO educationDTO)
        {
            await educationRepository.AddAsync(mapper.Map<Education>(educationDTO));
        }

        public async Task <IEnumerable<EducationDTO>> GetEducationsWithEmployeeIdAsync(int EmployeeId)
        {
            
            List<Education> educations= await educationRepository.GetEducationsWithEmployeeIdAsync(EmployeeId);

            return educations.Select(e => mapper.Map<EducationDTO>(e)).ToList();

        }

        public async Task<bool> RemoveEducationAsync(int Id)
        {
            bool result = await educationRepository.DeleteAsync(Id);
            return result;
        }

        public async Task<bool> UpdateEducationAsync(EducationUpdateDTO educationUpdateDTO)
        {
             bool result= await educationRepository.UpdateAsync(mapper.Map<Education>(educationUpdateDTO));
            return result;
        }

        public async Task<IEnumerable<EducationDTO>> GetEducationsAsync()
        {
            List<Education> educations= await educationRepository.GetAllAsync();
            return educations.Select(e => mapper.Map<EducationDTO>(e)).ToList();
        }
    }
}
