using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Enums;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
    public class SkillDegree : BaseEntity
    {
        public SkillLevelType Degree { get; set; } // Məharət dərəcəsi
        public DateTime AssignmentDate { get; set; } // Dərəcənin verilmə tarixi
        public int OrderId { get; set; } // Əmr nömrəsi
        public Order Order { get; set; }
        public int EmployeeNotebookId { get; set; }
        public  EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
