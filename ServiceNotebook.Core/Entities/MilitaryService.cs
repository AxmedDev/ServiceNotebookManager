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
        public MilitaryRankType MilitaryRank { get; set; } // Hərbi rütbə
        public string Specialization { get; set; } // İxtisas
        public DateTime AssignmentDate { get; set; } // Təyin olunma tarixi
        public int OrderId { get; set; } // Əmr id
        public Order Order { get; set; }
        public int EmployeeNotebookId { get; set; }
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
