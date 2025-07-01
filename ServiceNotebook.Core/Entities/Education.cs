using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
    public class Education : BaseEntity
    {
        public string EducationLevel { get; set; } 
        public string InstitutionName { get; set; } 
        public string Faculty { get; set; } 
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; } 
        public string DiplomaNumber { get; set; }
        public DateTime DiplomaDate { get; set; }  
        public int EmployeeNotebookId { get; set; }
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
