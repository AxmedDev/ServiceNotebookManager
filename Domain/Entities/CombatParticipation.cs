using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CombatParticipation
    {
        public int Id { get; set; }
        public DateTime ParticipationDate { get; set; }
        public string? Location { get; set; }
        public string? Injuries { get; set; }
        public string? VeteranStatus { get; set; }
        public int ServiceNotebookId { get; set; }
        public ServiceNotebook? ServiceNotebook { get; set; }
    }
}
