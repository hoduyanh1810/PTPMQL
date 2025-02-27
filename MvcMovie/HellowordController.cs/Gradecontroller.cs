using System.Web.Mvc;
using GradeCalculatorApp.Models;

namespace GradeCalculatorApp.Controllers
{
    public class GradeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(GradeCalculator model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateGrade();
                ViewBag.Result = $"Điểm trung bình: {model.AverageScore:F2} - Xếp loại: {model.Grade}";
            }
            return View(model);
        }
    }
}

