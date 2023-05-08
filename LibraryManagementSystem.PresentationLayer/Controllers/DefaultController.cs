using LibraryManagementSystem.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HomePage()
        {
            return View();
        }
    }
}
