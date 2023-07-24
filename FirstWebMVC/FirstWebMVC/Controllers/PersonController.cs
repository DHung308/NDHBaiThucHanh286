using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string message = ps.FullName + "-" + ps.ID;
            ViewBag.thongBao = message;
            return View();
        }
    }
}
