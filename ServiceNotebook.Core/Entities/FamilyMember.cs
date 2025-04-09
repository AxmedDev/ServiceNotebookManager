using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
    public class FamilyMember : BaseEntity
    {
        public string FullName { get; set; } // Tam adı
        public DateTime DateOfBirth { get; set; } // Doğum tarixi
        public string Relationship { get; set; } // Qohumluq dərəcəsi (ər, arvad, uşaq və s.)
        public string Address { get; set; } = null; // Yaşadığı ünvan
        public int EmployeeNotebookId { get; set; }
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
