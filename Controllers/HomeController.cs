using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Library2._0.Models;
using Library2._0.Services;
using Library2._0.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Library2._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IBookService _bookService;

        public HomeController(IBookRepository bookRepository, IBookService bookService)
        {
            _bookRepository = bookRepository;
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var books = _bookRepository.GetAllBooks().OrderBy(p => p.Name);
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to my library",
                Books = books.ToList()
            };
            return View("~/Views/Additional/Index.cshtml", homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var book = _bookRepository.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            };
            return View(book);
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult StatusChange(int id)
        {
            _bookService.ChangeStateById(id);
            return RedirectToAction(nameof(Details), "Home", new { id = id });
        }


        public IActionResult AddBooks(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookRepository.AddBook(book);
                return RedirectToAction("Index", "Home");
            }
            return View(book);
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
