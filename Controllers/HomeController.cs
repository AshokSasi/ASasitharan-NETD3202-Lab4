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
        public static List<book> booklist = new List<book>();
      
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
            
            if (ModelState.IsValid)
            {

                booklist.Add(new book(textbook.title,textbook.isbn,textbook.version,textbook.purchasePrice,textbook.condition));
               
                ViewData["Message"] = textbook.ToString();
             
                return View("Appraised");
            }
            else
            {
                return View("Failure");
            }
        }
        //send the book list
        public IActionResult AppraiseList()
        {
            
           
          
            return View(booklist);
        }
    }
}
