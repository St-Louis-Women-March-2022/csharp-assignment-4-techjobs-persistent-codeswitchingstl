using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistentAutograded.Models;

namespace TechJobsPersistentAutograded.ViewModels
{
    //Create a new ViewModel called AddJobViewModel. You will need properties for the job’s name, the selected employer’s ID, and a list of all employers as SelectListItem.
    public class AddJobViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Job name is required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Employer is required")]
        public int EmployerId { get; set; }
        
        public List<SelectListItem> Employers { get; set; }
        public List<SelectListItem> JobSkills { get; set; }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();
            
            foreach (var employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }

        public AddJobViewModel()
        {

        }
    }
}