using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceNotebook.BLL.DTOs.Education
{
    public  class EducationCreateDTO
    {
        public string EducationLevel { get; set; } // Təhsil pilləsi (orta, ali, bakalavr, magistr və s.)
        public string InstitutionName { get; set; } // Təhsil müəssisəsinin adı
        public string Faculty { get; set; } // Fakültə 
        
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } // Təhsilə başlama tarixi

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; } // Təhsili bitirmə tarixi
        public string DiplomaNumber { get; set; } // Diplomun nömrəsi
        
        [DataType(DataType.Date)]
        public DateTime DiplomaDate { get; set; }  // Diplomun verilmə tarixi
        public int EmployeeNotebookId { get; set; }
    }
}
