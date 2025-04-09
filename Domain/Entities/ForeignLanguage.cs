using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ForeignLanguage
    {
        public int Id { get; set; }
        public string? Language { get; set; } // Dil adı
        public string? ProficiencyLevel { get; set; } // Bilik səviyyəsi (zəif, yaxşı, sərbəst)
        public int ServiceNotebookId { get; set; }
        public ServiceNotebook? ServiceNotebook { get; set; }
    }
}
