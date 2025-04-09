using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HealthStatus
    {
        public int Id { get; set; }
        public string? MedicalInstitution { get; set; } // Tibb müəssisəsinin adı
        public DateTime ExaminationDate { get; set; } // Müayinə tarixi
        public string? Diagnosis { get; set; } // Diaqnoz
        public string? ServiceSuitability { get; set; } // Hərbi xidmətə yararlılıq (A, B, C, Ç, D)
        public int ServiceNotebookId { get; set; }
        public ServiceNotebook? ServiceNotebook { get; set; }
    }
}
