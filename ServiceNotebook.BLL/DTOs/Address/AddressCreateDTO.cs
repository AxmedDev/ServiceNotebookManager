using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.BLL.Attributes;

namespace ServiceNotebook.BLL.DTOs.Address
{
    public  class AddressCreateDTO
    {
        
        public string Street { get; set; }

        [Required]
        [AzOnlyLetter]
        public string City { get; set; }
        public int EmployeeNotebookId { get; set; }
    }
}
