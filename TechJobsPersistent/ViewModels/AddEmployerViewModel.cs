using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Employer Name is required")]
        [StringLength(50,MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Employer Location is required")]
        [StringLength(30,MinimumLength = 3)]
        public string Location { get; set; }
    }
}
