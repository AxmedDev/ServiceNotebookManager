using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceNotebook.BLL.Attributes
{
    public  class AzPhoneNumberAttribute : RegularExpressionAttribute
    {
        public AzPhoneNumberAttribute()
            : base(@"^\+994|0(60|10|50|51|55|70|77|99)[0-9]{7}$")
        {
            ErrorMessage = "{0} Azərbaycan mobil nömrəsi formatında olmalıdır.";
        }
    }
}
