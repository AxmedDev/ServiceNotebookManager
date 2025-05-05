using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Entities.Register;

namespace ServiceNotebook.Core.Repositories
{
    public  interface IUserRepository: IGeneralRepository<User>
    {
        Task<User> FindUser(string Username, string PasswordHash);
    }
}
