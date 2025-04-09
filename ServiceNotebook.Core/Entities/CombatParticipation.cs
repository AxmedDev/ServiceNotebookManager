using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Enums;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
    public class CombatParticipation : BaseEntity
    {
        public DateTime ParticipationDate { get; set; } // İştirak tarixi
        public string Location { get; set; } // İştirak edilən ərazi
        public string Injuries { get; set; } = null; // Aldığı yaralar və ya zədələr
        public VeteranStatusType VeteranStatus { get; set; } // Veteran statusu
        public int EmployeeNotebookId { get; set; }
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
