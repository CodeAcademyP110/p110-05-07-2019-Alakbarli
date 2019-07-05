using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.DAL;

namespace WebApplication3.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryDb context;
        public BookController(LibraryDb db)
        {
            context = db;
        }
        public IActionResult GetAllBooks()
        {
            return Json(context.Books.ToList());
        }
    }
}