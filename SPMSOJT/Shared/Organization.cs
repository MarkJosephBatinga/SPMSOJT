using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMSOJT.Shared
{
    public class Organization
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Organization Name is Required")]
        public string org_name { get; set; }

        [Required(ErrorMessage = "Branch Address is Required")]
        public string branch_address { get; set; }

        [Required(ErrorMessage = "Contact Person is Required")]
        public string contact_person { get; set; }

        [Required(ErrorMessage = "Contact Number is Required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string contact_number { get; set; }
    }
}
