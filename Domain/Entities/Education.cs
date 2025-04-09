using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Education
    {
        public int Id { get; set; }
        public string? EducationLevel { get; set; }
        public string? InstitutionName { get; set; }
        public string? Faculty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? DiplomaNumber { get; set; }
        public DateTime DiplomaDate { get; set; }
        public int ServiceNotebookId { get; set; }
        public ServiceNotebook? ServiceNotebook { get; set; }
    }
}
