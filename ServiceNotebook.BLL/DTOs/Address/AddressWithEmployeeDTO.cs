using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.BLL.Models.Employee;

namespace ServiceNotebook.BLL.DTOs.Address
{
    public  class AddressWithEmployeeDTO
    {
        public int Id;
        public string Street { get; set; }
        public string City { get; set; }
        public EmployeeNotebookDTO Employee { get; set; }

    }
}
