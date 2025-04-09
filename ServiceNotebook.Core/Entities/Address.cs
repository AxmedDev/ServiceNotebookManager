using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
#nullable enable
    public class Address : BaseEntity
    {
        public string Street { get; set; }
        public string City { get; set; } 
        public int EmployeeNotebookId { get; set; } 
        public EmployeeNotebook EmployeeNotebook { get; set; }
    }
}
