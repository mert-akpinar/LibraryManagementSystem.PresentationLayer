using LibraryManagementSystem.BusinessLayer.Abstract;
using LibraryManagementSystem.BusinessLayer.Concrete;
using LibraryManagementSystem.DataAccessLayer.Concrete;
using LibraryManagementSystem.DataAccessLayer.Repositories;
using LibraryManagementSystem.EntityLayer.Concrete;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace LibraryManagementSystem.PresentationLayer.Controllers
{ 
	public class LibraryController : Controller
	{
        private readonly IBookService _bookService;
        
        public LibraryController(IBookService bookService)
        {
            _bookService = bookService;
        }
        
        public IActionResult Index(string searchType, string searchString)
        {
            var values = _bookService.TGetListBookWithAuthorANDCategory();
            if (!string.IsNullOrEmpty(searchString))
            {
                switch (searchType)
                {
                    case "BookTitle":
                        values = values.Where(b => b.BookTitle.Contains(searchString)).ToList();
                        break;                    
                    case "AuthorName":
                        values = values.Where(b => b.AuthorName.Contains(searchString)).ToList();
                        break;
                    case "publishing":
                        values = values.Where(b => b.publishing.Contains(searchString)).ToList();
                        break;
                    default:
                        values = values.Where(b => b.BookTitle.Contains(searchString)).ToList();
                        break;
                }
            }
            return View(values);
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _bookService.TInsert(book);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteBook(int id)
        {
            var value = _bookService.TGetByID(id); 
            _bookService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateBook(int id)
        {
            var values = _bookService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateBook(Book book)
        {
            _bookService.TUpdate(book);
            return RedirectToAction("Index");
            
        }
    }
}
