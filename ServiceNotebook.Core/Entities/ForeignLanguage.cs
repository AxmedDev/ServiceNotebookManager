using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
    public class ForeignLanguage : BaseEntity
    {
        public string Language { get; set; }
        public string ProficiencyLevel { get; set; } // Bilik səviyyəsi (zəif, yaxşı, sərbəst)
        public int EmployeeNotebookId { get; set; }
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
