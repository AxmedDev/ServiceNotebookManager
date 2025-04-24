using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceNotebook.BLL.Attributes;

namespace ServiceNotebook.BLL.DTOs.Employee
{
    public class EmployeeNotebookUpdateDTO
    {
        public int Id { get; set; }

        [Required]
        [AzOnlyLetter]
        public string Name { get; set; }

        [Required]
        [AzOnlyLetter]
        public string Surname { get; set; }

        [Required]
        [AzOnlyLetter]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Birthday boş ola bilməz.")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required]
        [AzOnlyLetter]
        public string Citizenship { get; set; }

        [Required]
        [AzOnlyLetter]
        public string Nationality { get; set; }

        [Required]
        public bool IsMarried { get; set; }

        [Required]
        [AzPhoneNumber]
        public string MainPhoneNumber { get; set; }

        [AzPhoneNumber]
        public string OtherPhoneNumber { get; set; } = null;

        [EmailAddress(ErrorMessage = "Email düzgün formatda deyil.")]
        public string Email { get; set; } = null;

    }
}
