using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ServiceNotebook.BLL.DTOs.User;
using ServiceNotebook.Core.Entities.Register;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.BLL.Services
{
    public class UserService
    {
        private readonly IUserRepository service;
        private readonly IMapper mapper;
        public UserService( IUserRepository service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        public async Task<List<User>> GetUsersAsync()
        { 
            return await service.GetAllAsync();
        }

        public async Task RegisterUserAsync(UserCreateDTO userCreateDTO)
        {
           await service.AddAsync(mapper.Map<User>(userCreateDTO));
        }

        public async Task<User?> ValidateUser(string username, string password)
        {
            return await service.FindUser(username, password);
           
        }
    }
}
