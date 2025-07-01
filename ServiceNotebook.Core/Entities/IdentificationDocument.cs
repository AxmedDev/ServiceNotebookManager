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
     
        public string DocumentNumber { get; set; } 
        public IdentificationType DocumentType { get; set; } 
        public DateTime IssueDate { get; set; } 
        public DateTime ExpiryDate { get; set; }
        public string IssuingAuthority { get; set; } 
        public BloodType BloodType { get; set; } 
        public int EmployeeNotebookId { get; set; }
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
