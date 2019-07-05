using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.DAL;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryDb context;
        public HomeController(LibraryDb db)
        {
            context = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Books = context.Books,
                Authors = context.Authors,
                Languages = context.Languages
            };
            return View(homeVM);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
