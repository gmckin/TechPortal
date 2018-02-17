using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPortal.Data.Domain.DataAccessObjects
{
    public class JobTitleDAO
    {
        [Required]
        [StringLength(50, ErrorMessage = "Length must be between 2 and 100.", MinimumLength = 2)]
        public string JobTitleName { get; set; }
    }
}
