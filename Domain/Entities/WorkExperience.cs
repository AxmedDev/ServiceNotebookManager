using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class WorkExperience
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; } // İşə başlama tarixi
        public DateTime EndDate { get; set; } // İşdən ayrılma tarixi
        public string? Workplace { get; set; } // İş yeri adı
        public string? Position { get; set; } // Vəzifə
        public int ServiceNotebookId { get; set; }
        public ServiceNotebook? ServiceNotebook { get; set; }
    }
}
