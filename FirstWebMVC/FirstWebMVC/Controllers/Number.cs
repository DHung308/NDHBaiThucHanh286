using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class Number : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int Numbers, int Numbers2)
        {
            Numbers2 = Numbers * Numbers;
            ViewBag.thongBao = "Bình phương số vừa nhập =" + Numbers2;
            return View();
        }


    }
}
