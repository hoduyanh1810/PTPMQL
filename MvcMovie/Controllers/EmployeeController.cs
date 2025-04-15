using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Thêm nhân viên thành công!";
                return View("Details", employee);
            }
            return View(employee);
        }

        public IActionResult Details(Employee employee)
        {
            return View(employee);
        }
    }
}
