using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String Ibrahim()
        {
            return "Hello Ibrahim Medhat";
        }

        public String Welcome()
        {
            return "Hello Hi";
        }

    }
}