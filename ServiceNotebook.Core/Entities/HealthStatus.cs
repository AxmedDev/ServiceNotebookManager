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
        public string MedicalInstitution { get; set; } // Tibb müəssisəsinin adı
        public DateTime ExaminationDate { get; set; } // Müayinə tarixi
        public string Diagnosis { get; set; } // Diaqnoz
        public ServiceSuitabilityType ServiceSuitability { get; set; } // Hərbi xidmətə yararlılıq (A, B, C, Ç, D)
        public int EmployeeNotebookId { get; set; }
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
