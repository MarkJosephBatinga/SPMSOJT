using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMSOJT.Shared
{
    public class CompiledTask
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TaskId { get; set; }
        [Required(ErrorMessage = "File is Required")]
        public string StudentFile { get; set; }
        public string StudentFileName { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Remarks { get; set; }
        public int Score { get; set; }

        [NotMapped]
        public string TaskCode { get; set; }
        [NotMapped]
        public string StudentName { get; set; }
    }
}
