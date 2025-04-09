using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
    public class Education : BaseEntity
    {
        public string EducationLevel { get; set; } // Təhsil pilləsi (orta, ali, bakalavr, magistr və s.)
        public string InstitutionName { get; set; } // Təhsil müəssisəsinin adı
        public string Faculty { get; set; } // Fakültə 
        public DateTime StartDate { get; set; } // Təhsilə başlama tarixi
        public DateTime EndDate { get; set; } // Təhsili bitirmə tarixi
        public string DiplomaNumber { get; set; } // Diplomun nömrəsi
        public DateTime DiplomaDate { get; set; }  // Diplomun verilmə tarixi
        public int EmployeeNotebookId { get; set; }
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
