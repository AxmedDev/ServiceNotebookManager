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
        public string EducationLevel { get; set; } 
        public string InstitutionName { get; set; } 
        public string Faculty { get; set; }  
        
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } 

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; } 
        public string DiplomaNumber { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DiplomaDate { get; set; }  
        public int EmployeeNotebookId { get; set; }
    }
}
