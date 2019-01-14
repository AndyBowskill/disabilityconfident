using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DisabledConfidentWebsite.Models;
using DisabledConfidentWebsite.Repositories;

namespace DisabledConfidentWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployerRepository _employerRepository;

        public HomeController(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public Employer GetAll()
        {
            return _employerRepository.GetAll();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
