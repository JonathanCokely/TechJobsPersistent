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
        [Required(ErrorMessage ="Job name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Employer Id is required")]
        public int EmployerId { get; set; }

        public List<SelectListItem> EmployerList { get; set; }

        //[Required(ErrorMessage = "Skill Id is required")]
        //public int SkillId { get; set; }
        public AddJobViewModel(List<Employer> employers)
        {
            EmployerList = new List<SelectListItem>();

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
        }

        public AddJobViewModel() { }

    }
}