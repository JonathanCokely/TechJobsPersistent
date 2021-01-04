using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddSkillViewModel
    {
        [Required(ErrorMessage = "Skill Name is required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Skill Description is required")]
        [StringLength(50, MinimumLength = 3)]
        public string Description { get; set; }
    }
}
