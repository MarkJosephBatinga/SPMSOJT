using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMSOJT.Shared
{
    public class Coordinator
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string last_name { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        public string first_name { get; set; }

        [Required(ErrorMessage = "Barangay is Required")]
        public string barangay { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public string city { get; set; }

        [Required(ErrorMessage = "Province is Required")]
        public string province { get; set; }

        [Required(ErrorMessage = "Zipcode is Required")]
        public string zipcode { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string phonenum { get; set; }

        [Required(ErrorMessage = "School Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid School Email Address")]
        public string schoolemail { get; set; }

        [Required(ErrorMessage = "password is Required")]
        [MinLength(8, ErrorMessage = "8 Minimum Characters Required")]
        public string password { get; set; }

    }
}
