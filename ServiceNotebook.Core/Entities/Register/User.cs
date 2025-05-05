using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.Core.Repositories;

namespace ServiceNotebook.Core.Entities.Register
{
    public  class User: BaseEntity
    {
        public  string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } = "User";
    }
}
