using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASasitharan_NETD3202_Lab4.Models;

namespace ASasitharan_NETD3202_Lab4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Appraise()
        {
            return View();
        }
    }
}
