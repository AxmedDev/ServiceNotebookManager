using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.BLL.Models.Employee;
using ServiceNotebook.Core.Entities;



namespace ServiceNotebook.BLL.DTOs.Education
{
    public class EducationDTO
    {
        public string EducationLevel { get; set; }
        public string InstitutionName { get; set; }
        public string Faculty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DiplomaNumber { get; set; }
        public DateTime DiplomaDate { get; set; }

        public EmployeeNotebookDTO Employee { get; set; }



    }
}
