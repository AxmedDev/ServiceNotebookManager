using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceNotebook.BLL.Attributes
{
    public class AzOnlyLetterAttribute : RegularExpressionAttribute
    {
        public AzOnlyLetterAttribute()
        : base(@"^[A-ZƏÇŞĞÜÖİ][a-zəçşğüöı]+$")
        {
            ErrorMessage = "{0} yalnız hərflərdən ibarət olmalı və böyük hərflə başlamalıdır.";
        }
    }
}
