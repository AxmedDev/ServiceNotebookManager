using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Entities;

namespace ServiceNotebook.Core.Repositories
{
    public interface IEducationRepository: IGeneralRepository<Education>
    {
        Task<List<Education>> GetEducationsWithEmployeeIdAsync(int EmployeeId);
        
    }
}
