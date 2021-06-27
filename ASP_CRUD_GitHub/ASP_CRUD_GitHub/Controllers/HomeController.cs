using ASP_CRUD_GitHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ASP_CRUD_GitHub.Models;

namespace ASP_CRUD_GitHub.Controllers
{


    public class HomeController : Controller
    {
        List<StudentModel> Students = new List<StudentModel>
            {
                new StudentModel {Id = 1 , name ="Batool"},
                new StudentModel {Id = 2 , name ="Reema"}

        };


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //<<Read>>
        //Get: /
        public IActionResult Index()
        {
            ViewData["Students"] = Students;
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
