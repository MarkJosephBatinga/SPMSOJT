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
        public User student { get; set; }

        [Required(ErrorMessage = "Supervisor is Required")]
        public Supervisor supervisor { get; set; }

        [Required(ErrorMessage = "Organization is Required")]
        public Organization organization { get; set; }
    }
}
