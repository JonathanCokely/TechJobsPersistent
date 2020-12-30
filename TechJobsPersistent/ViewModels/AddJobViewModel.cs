﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employer is required")]
        public int EmployerId { get; set; }

        public List<SelectListItem> EmployerList { get; set; }

        public List<Skill> SkillList { get; set; }

        [Required(ErrorMessage = "Select at least 1 Skill")]
        public string[] SelectedSkills { get; set; }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            EmployerList = new List<SelectListItem>();
            SkillList = new List<Skill>();


            foreach(var employer in employers)
            {
                EmployerList.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    }
                );
            }

            foreach(var skill in skills)
            {
                SkillList.Add(
                    new Skill
                    {
                        Name = skill.Name,
                        Description = skill.Description
                    }
                );

            }
        }

        public AddJobViewModel() {}

    }
}
