using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Enums;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
    public class HealthStatus : BaseEntity
    {
        public string MedicalInstitution { get; set; } 
        public DateTime ExaminationDate { get; set; }
        public string Diagnosis { get; set; } 
        public ServiceSuitabilityType ServiceSuitability { get; set; } 
        public int EmployeeNotebookId { get; set; }
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
