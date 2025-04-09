using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Entities;

namespace ServiceNotebook.BLL.Models.Employee
{
    public class EmployeeNotebookDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public DateTime Birthday { get; set; }
        public string Citizenship { get; set; }
        public string Nationality { get; set; }
        public bool IsMarried { get; set; }
        public string MainPhoneNumber { get; set; }
        public string OtherPhoneNumber { get; set; } = null;
        public string Email { get; set; } = null;


    }
}
