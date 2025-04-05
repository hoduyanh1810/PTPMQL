using Microsoft.AspNetCore.Mvc;
using BTH.Models;

namespace BTH.Controllers
{
    public class GradeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateGrade(GradeModel model)
        {
            if (ModelState.IsValid)
            {
                model.FinalGrade = (model.A * 0.4f) + (model.B * 0.3f) + (model.C * 0.3f);
                ViewBag.FinalGrade = model.FinalGrade;
            }
            return View("Index");
        }
    }
}
