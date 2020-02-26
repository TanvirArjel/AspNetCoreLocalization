using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreLocalization.Models
{
    public class EmployeeViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "The {0} field is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The {0} field is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The {0} field is required.")]
        [Display(Name = "Department")]
        public string Department { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "The {0} field is required.")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
    }
}
