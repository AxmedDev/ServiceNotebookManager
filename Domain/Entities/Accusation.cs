using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Accusation
    {
        public int Id { get; set; } // Unikal identifikator
        public string? IncidentDescription { get; set; } // Hadisənin təsviri  Xidməti vəzifələrin yerinə yetirilməməsi
        public DateTime IncidentDate { get; set; } // Hadisənin baş verdiyi tarix
        public string? IncidentLocation { get; set; } // Hadisənin baş verdiyi yer
        public string? AccusationType { get; set; } // Töhmetin növü (inzibati, cinayət, maddi və s.)
        public string? Decision { get; set; } // Qərar (məsələn, cəza, xəbərdarlıq, bəraət)
        public DateTime DecisionDate { get; set; } // Qərarın verilmə tarixi
        public string? IssuingAuthority { get; set; } // Qərarı verən orqan
        public string? Notes { get; set; } // Əlavə qeydlər
        public int ServiceNotebookId { get; set; } // Xidmət dəftərçəsi ilə əlaqə
        public ServiceNotebook? ServiceNotebook { get; set; } // Navigation property
    }
}
