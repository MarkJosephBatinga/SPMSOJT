using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMSOJT.Shared
{
    public class Tasks
    {
        public int Id { get; set; }

        public int SupervisorId { get; set; }

        [Required(ErrorMessage = "Task Code is Required")]
        public string TaskCode { get; set; }

        [Required(ErrorMessage = "Task Name is Required")]
        public string TaskName { get; set; }

        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Deadline is Required")]
        public DateTime Deadline { get; set; }
    }
}
