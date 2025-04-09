using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Enums;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities
{
    public  class Order : BaseEntity
    {
        public string OrderNumber { get; set; } 
        public DateTime OrderDate { get; set; } 
        public OrderType Type { get; set; }
        public string Reason { get; set; } = null;
        public  List<EmployeeNotebook> EmployeeNotebooks { get; set; }
    }
}
