using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MilitaryService
    {
        public int Id { get; set; }
        public string? MilitaryRank { get; set; } // Hərbi rütbə
        public string? Specialization { get; set; } // İxtisas
        public DateTime AssignmentDate { get; set; } // Təyin olunma tarixi
        public string? AssignmentOrderNumber { get; set; } // Əmr nömrəsi
        public int ServiceNotebookId { get; set; }
        public ServiceNotebook? ServiceNotebook { get; set; }
    }
}
