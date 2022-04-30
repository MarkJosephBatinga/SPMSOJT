using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMSOJT.Shared
{
    public class Trainee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "School Year is Required")]
        public string school_year { get; set; }

        [Required(ErrorMessage = "Student is Required")]
        [Range(1,9999999, ErrorMessage = "Student is Required")]
        public int studentId { get; set; }

        [Required(ErrorMessage = "Supervisor is Required")]
        [Range(1, 9999999, ErrorMessage = "Supervisor is Required")]
        public int supervisorId { get; set; }

        [Required(ErrorMessage = "Organization is Required")]
        [Range(1, 9999999, ErrorMessage = "Supervisor is Required")]
        public int organizationId { get; set; }
    }
}
