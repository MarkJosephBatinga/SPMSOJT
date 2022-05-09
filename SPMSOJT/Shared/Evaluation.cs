using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMSOJT.Shared
{
    public class Evaluation
    {
        public int Id { get; set; }
        public int TraineeId { get; set; }
        [Required(ErrorMessage = "Responsibility Rating is Required")]
        [StringLength(maximumLength:1, MinimumLength = 1, ErrorMessage = "Invalid Rating")]
        public string Responsibilty { get; set; }
        [Required(ErrorMessage = "Competence Rating is Required")]
        [StringLength(maximumLength: 1, MinimumLength = 1, ErrorMessage = "Invalid Rating")]
        public string Competence { get; set; }
        [Required(ErrorMessage = "Cooperation Rating is Required")]
        [StringLength(maximumLength: 1, MinimumLength = 1, ErrorMessage = "Invalid Rating")]
        public string Cooperation { get; set; }
        [Required(ErrorMessage = "Quality of Service Rating is Required")]
        [StringLength(maximumLength: 1, MinimumLength = 1, ErrorMessage = "Invalid Rating")]
        public string QualityOfService { get; set; }
    }
}
