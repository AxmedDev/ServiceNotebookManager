using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceNotebook.Core.Entities;
using ServiceNotebook.Core.Repositories;
using ServiceNotebook.DAL.MyDbContext;

namespace ServiceNotebook.DAL.Repositories
{
    public class AddressRepository : GeneralRepository<Address>,IAddressRepository
    {
        public AddressRepository(ServiceNotebookDB dbContext) : base(dbContext)
        {
        }
        public async Task<List<Address>> GetAddressesWithEmployeeIdAsync(int EmployeeId)
        {
            return await dbSet.Include(x=>x.EmployeeNotebook).Where(x=>x.EmployeeNotebookId== EmployeeId).ToListAsync();

        }
    }
}
