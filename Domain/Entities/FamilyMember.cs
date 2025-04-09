using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FamilyMember
    {
        public int Id { get; set; }
        public string? FullName { get; set; } // Tam adı
        public DateTime DateOfBirth { get; set; } // Doğum tarixi
        public string? Relationship { get; set; } // Qohumluq dərəcəsi (ər, arvad, uşaq və s.)
        public string? Address { get; set; } // Yaşadığı ünvan
        public int ServiceNotebookId { get; set; }
        public ServiceNotebook? ServiceNotebook { get; set; }
    }
}
