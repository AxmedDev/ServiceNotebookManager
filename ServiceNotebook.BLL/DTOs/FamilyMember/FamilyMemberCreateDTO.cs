using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Entities;

namespace ServiceNotebook.BLL.DTOs.FamilyMember
{
    public class FamilyMemberCreateDTO
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; } 
        public string Relationship { get; set; } 
        public string Address { get; set; } = null; 
        public int EmployeeNotebookId { get; set; }
       
    }
}
