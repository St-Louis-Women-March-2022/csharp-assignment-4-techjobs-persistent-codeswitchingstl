using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistentAutograded.Models;

namespace TechJobsPersistentAutograded.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Employer name is required")]
        public string EmployerName { get; set; }

        [Required(ErrorMessage = "EMployer location is required")]
        public string EmployerLocation { get; set; }

        /*public AddEmployerViewModel(Job theJob, List<Skill> possibleSkills)
        {
            Skills = new List<SelectListItem>();

            foreach (var skill in possibleSkills)
            {
                Skills.Add(new SelectListItem
                {
                    Value = skill.Id.ToString(),
                    Text = skill.Name
                });
            }

            Job = theJob;
        }*/

        public AddEmployerViewModel()
        {
        }
    }
}

