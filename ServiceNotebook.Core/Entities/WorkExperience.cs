using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
    public class WorkExperience : BaseEntity
    {
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; } 
        public string Workplace { get; set; } 
        public string Position { get; set; } 
        public int EmployeeNotebookId { get; set; }
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
