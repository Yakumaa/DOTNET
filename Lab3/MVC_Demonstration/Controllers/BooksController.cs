using Microsoft.AspNetCore.Mvc;
using MVC_Demonstration.Models;

namespace MVC_Demonstration.Controllers
{
    public class BooksController : Controller
    {
        private static List<Book> books = new List<Book>
    {
        new Book { Id = 1, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
        new Book { Id = 2, Title = "1984", Author = "George Orwell", Year = 1949 },
        new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 }
    };

        // GET: /Books
        public IActionResult Index()
        {
            return View(books);
        }

        // GET: /Books/Details/5
        public IActionResult Details(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // GET: /Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id = books.Max(b => b.Id) + 1;
                books.Add(book);
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
    }
}
