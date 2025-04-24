using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceNotebook.BLL.DTOs.FamilyMember
{
    public  class FamilyMemberDTO
    {
        public string FullName { get; set; } 
        public DateTime DateOfBirth { get; set; } 
        public string Relationship { get; set; } 
        public string Address { get; set; } = null; 
    }
}
