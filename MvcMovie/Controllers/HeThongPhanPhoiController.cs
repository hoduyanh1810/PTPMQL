using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HeThongPhanPhoiController : Controller
    {
        public IActionResult Index()
        {
            var htpps = new List<HeThongPhanPhoi>
            {
                new HeThongPhanPhoi { MaHTPP = "HTPP01", TenHTPP = "Hệ thống A" },
                new HeThongPhanPhoi { MaHTPP = "HTPP02", TenHTPP = "Hệ thống B" }
            };

            return View(htpps);
        }

        public IActionResult Details(string id)
        {
            var htpp = new HeThongPhanPhoi { MaHTPP = "HTPP01", TenHTPP = "Hệ thống A" };
            return View(htpp);
        }
    }
}
