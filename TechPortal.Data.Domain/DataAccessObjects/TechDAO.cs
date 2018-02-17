using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TechPortal.Data.Domain.DataAccessObjects
{
    public class TechDAO
    {

        Crud.AccessHelper ah = new Crud.AccessHelper();

        public TechDAO() { }

        public TechDAO(string name, string email, string phone, string jobtitle, string location, string techrole, string shiftstatus)
        {
            Name = name;
            Email = email;
            Phone = phone;
            JobTitle = jobtitle;
            Location = location;
            TechRole = techrole;
            ShiftStatus = shiftstatus; 
        }

        [Required]
        [StringLength(50, ErrorMessage = "Length must be between 2 and 100.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Length must be between 2 and 100.", MinimumLength = 2)]
        public string Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Length must be between 2 and 100.", MinimumLength = 2)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Length must be between 2 and 100.", MinimumLength = 2)]
        public string JobTitle { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Length must be between 2 and 100.", MinimumLength = 2)]
        public string Location { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Length must be between 2 and 100.", MinimumLength = 2)]
        public string TechRole { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Length must be between 2 and 100.", MinimumLength = 2)]
        public string ShiftStatus { get; set; }


    }
}
