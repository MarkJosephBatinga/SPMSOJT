using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMSOJT.Shared
{
    public class Search
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        public string SearchString { get; set; }
    }
}
