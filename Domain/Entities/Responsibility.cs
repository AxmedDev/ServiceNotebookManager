using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Responsibility
    {
        public int Id { get; set; }
        public string? IncidentDescription { get; set; } // Hadisənin təsviri
        public DateTime IncidentDate { get; set; } // Hadisə tarixi
        public string? Decision { get; set; } // Qərar (məhkəmə, inzibati və s.)
        public int ServiceNotebookId { get; set; }
        public ServiceNotebook? ServiceNotebook { get; set; }
    }
}
