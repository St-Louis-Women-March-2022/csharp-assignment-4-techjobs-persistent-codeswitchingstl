using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistentAutograded.Data;
using TechJobsPersistentAutograded.Models;
using TechJobsPersistentAutograded.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistentAutograded.Controllers
{
    public class EmployerController : Controller
    {
        //setup a private JobRepository variable to perform CRUD operations on the database and pass into EmployerController constructor
        private JobRepository jobRepository;
        public EmployerController(JobRepository jobRepository)
        {
            this.jobRepository = jobRepository;
        }

        // GET: /<controller>/
        //passes all of the Employer objects in the database to the view
        public IActionResult Index()
        {
            IEnumerable<Employer> employers = jobRepository.GetAllEmployers();
            
            return View(employers);
        }

        //Create an instance of AddEmployerViewModel inside of the Add() method and pass the instance into the View() return method
        public IActionResult Add()
        {
            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel();
            
            return View(addEmployerViewModel);
        }

        [HttpPost]
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel)
        {
            if (ModelState.IsValid)
            {
                Employer employer = new Employer
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location
                };
                jobRepository.AddNewEmployer(employer);
                jobRepository.SaveChanges();

                return Redirect("/Employer");
            }
            
            return View(addEmployerViewModel);
        }

        //Make sure that the method is actually passing an Employer object to the view for display.
        public IActionResult About(int id)
        {
            Employer employer = jobRepository.FindEmployerById(id);
            
            return View(employer);
        }
    }
}

