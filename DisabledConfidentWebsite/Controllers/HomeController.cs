using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DisabledConfidentWebsite.Models;
using DisabledConfidentWebsite.Repositories;
using DisabledConfidentWebsite.ViewModels;

namespace DisabledConfidentWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployerRepository _employerRepository;

        public HomeController(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository;
        }

        //[Route("")]
        //[HttpGet]
        public IActionResult Index()
        {
            //var employersSector = new EmployerViewModel
            //{
            //    Employers = _employerRepository.GetAll(),
            //    Sector = ""
            //};

            return View();

            //return View(employersSector);
        }

        [HttpPost]
        public IActionResult Index(string sector)
        {
            var employersSector = new EmployerViewModel
            {
                Employers = _employerRepository.GetForSector(sector),
                Sector = sector
            };

            return View(employersSector);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
