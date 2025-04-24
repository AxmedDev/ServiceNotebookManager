using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.BLL.Models.Employee;

namespace ServiceNotebook.BLL.DTOs.Address
{
    public  class AddressDTO
    {
        public int Id {  get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int EmployeeNotebookId { get; set; }
       

    }
}
