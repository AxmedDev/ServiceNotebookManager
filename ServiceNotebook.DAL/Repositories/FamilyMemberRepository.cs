using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Entities;
using ServiceNotebook.Core.Repositories;
using ServiceNotebook.DAL.MyDbContext;

namespace ServiceNotebook.DAL.Repositories
{
    public class FamilyMemberRepository : GeneralRepository<FamilyMember>, IFamilyMemberRepository
    {
        public FamilyMemberRepository(ServiceNotebookDB dbContext) : base(dbContext)
        {
        }
    }
}
