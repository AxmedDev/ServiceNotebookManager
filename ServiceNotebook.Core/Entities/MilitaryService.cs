using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Enums;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
    public class MilitaryService : BaseEntity
    {
        public MilitaryRankType MilitaryRank { get; set; }
        public string Specialization { get; set; } 
        public DateTime AssignmentDate { get; set; } 
        public int OrderId { get; set; } 
        public Order Order { get; set; }
        public int EmployeeNotebookId { get; set; }
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
