using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ServiceNotebook.BLL.DTOs.Employee;
using ServiceNotebook.BLL.Models.Employee;
using ServiceNotebook.Core.Entities;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.BLL.Services
{
    public class EmployeeNotebookServices
    {
        private readonly IMapper mapper;
        private readonly IEmployeeNotebookRepository employeeRepository;
        public EmployeeNotebookServices(IEmployeeNotebookRepository employeeRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }


        public async Task<List<EmployeeNotebookDTO>> GetEmployesAsync()
        {
            List<EmployeeNotebookDTO> employeNotebookDTOs = new List<EmployeeNotebookDTO>();
            var employees = await employeeRepository.GetAllAsync();

            foreach (var employee in employees)
            {
                employeNotebookDTOs.Add(mapper.Map<EmployeeNotebookDTO>(employee));

            }
            return employeNotebookDTOs;
        }


        public async Task InsertEmployeeAsync(EmployeeNotebookCreateDTO employeeNotebookCreateDTO)
        {
           await employeeRepository.AddAsync(mapper.Map<EmployeeNotebook>(employeeNotebookCreateDTO));
        }
    
        public async Task<bool> RemoveEmployeeAsync(int Id)
        {
            bool result= await employeeRepository.DeleteAsync(Id);
            return result;
        }

        public async Task<bool> UpdateEmployeeAsync(EmployeeNotebookUpdateDTO employeeNotebookUpdateDTO)
        {
            bool result= await employeeRepository.UpdateAsync(mapper.Map<EmployeeNotebook>(employeeNotebookUpdateDTO));
            return result;
        }

        public async Task<EmployeeNotebookDTO> GetEmployeeByIdAsync(int Id)
        {
            EmployeeNotebook? employee= await employeeRepository.GetByIdAsync(Id);
            return mapper.Map<EmployeeNotebookDTO>(employee);
        }


    }
}
