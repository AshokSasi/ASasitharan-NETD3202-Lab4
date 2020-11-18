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
        //create new list of book
        List<book> bookList = new List<book>();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Appraise()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Appraise(book textbook)
        {
            if(ModelState.IsValid)
            {
                ViewData["Message"] = textbook.ToString();

                
                    return View("ViewAppraisal", textbook);
            }
            else
            {
                return View("Failure");
            }
        }
    }
}
