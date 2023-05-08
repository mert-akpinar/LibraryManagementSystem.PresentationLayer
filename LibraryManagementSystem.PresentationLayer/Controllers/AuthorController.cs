using LibraryManagementSystem.BusinessLayer.Abstract;
using LibraryManagementSystem.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.PresentationLayer.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }
        public IActionResult Index(string searchType, string searchString)
        {
            var values = _authorService.TGetList();
            if (!string.IsNullOrEmpty(searchString))
            {
                switch (searchType)
                {
                    case "AuthorName":
                        values = values.Where(b => b.AuthorName.Contains(searchString)).ToList();
                        break;
                    case "AuthorSurname":
                        values = values.Where(b => b.AuthorSurname.Contains(searchString)).ToList();
                        break;
                    default:
                        values = values.Where(b => b.AuthorName.Contains(searchString)).ToList();
                        break;
                }
            }
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAuthor(Author author)
        {
            _authorService.TInsert(author);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAuthor(int id)
        {
            var value = _authorService.TGetByID(id);
            _authorService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAuthor(int id)
        {
            var values = _authorService.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAuthor(Author author)
        {
            _authorService.TUpdate(author);
            return RedirectToAction("Index");

        }
    }
}
