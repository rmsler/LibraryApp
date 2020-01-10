using Library2._0.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Controllers
{
    public class AddBookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public AddBookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Add()
        {
            ViewData["Message"] = "Your add a book page.";

            return View();
        }
    }
}