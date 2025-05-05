using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceNotebook.Core.Entities.Register;
using ServiceNotebook.Core.Repositories;
using ServiceNotebook.DAL.MyDbContext;

namespace ServiceNotebook.DAL.Repositories
{
    public class UserRepository : GeneralRepository<User>, IUserRepository
    {
        public UserRepository(ServiceNotebookDB dbContext): base(dbContext) 
        {
            
        }

        public async Task<User?> FindUser(string Username, string PasswordHash)
        {
            return await dbSet.FirstOrDefaultAsync(x => x.UserName == Username && x.PasswordHash == PasswordHash);
        }
    }
}
