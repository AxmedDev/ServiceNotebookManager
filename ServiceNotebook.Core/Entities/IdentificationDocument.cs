using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Enums;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
    public class IdentificationDocument : BaseEntity
    {
     
        public string DocumentNumber { get; set; } // Şəxsiyyət vəsiqəsinin/Pasportun nömrəsi
        public IdentificationType DocumentType { get; set; } // Sənədin növü (şəxsiyyət vəsiqəsi, xarici pasport və s.)
        public DateTime IssueDate { get; set; } // Verilmə tarixi
        public DateTime ExpiryDate { get; set; } // Etibarlılıq müddəti
        public string IssuingAuthority { get; set; } // Verən qurum (Məsələn: DİN, Sərhəd Xidməti və s.)
        public BloodType BloodType { get; set; } 
        public int EmployeeNotebookId { get; set; }
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
