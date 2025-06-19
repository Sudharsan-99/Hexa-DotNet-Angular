// File: Controllers/BookController.cs
using Microsoft.AspNetCore.Mvc;
using BookValidationApp.Models; // Replace with your actual namespace
using System.Collections.Generic;
using System.Linq;

namespace BookValidationApp.Controllers
{
    public class BookController : Controller
    {
        static List<Book> books = new List<Book>();

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (books.Any(b => b.Isbn == book.Isbn))
            {
                ModelState.AddModelError("Isbn", "ISBN must be unique");
            }

            if (ModelState.IsValid)
            {
                books.Add(book);
                return RedirectToAction("BookList");
            }

            return View(book);
        }

        [HttpGet]
        public IActionResult BookList()
        {
            return View(books);
        }
    }
}
