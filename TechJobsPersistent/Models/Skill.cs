using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.Models
{
    public class Skill
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Skill Name is required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Skill Description is required")]
        [StringLength(50, MinimumLength = 3)]
        public string Description { get; set; }

        public Skill()
        {
        }

        public Skill(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
