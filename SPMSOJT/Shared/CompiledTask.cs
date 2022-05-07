using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMSOJT.Shared
{
    public class CompiledTask
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        [Required(ErrorMessage = "File is Required")]
        public string StudentFile { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Remarks { get; set; }
        public int Score { get; set; }
    }
}
