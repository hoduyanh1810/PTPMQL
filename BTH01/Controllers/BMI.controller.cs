using System;
using System.Web.Mvc;
using BMICalculatorApp.Models;

namespace BMICalculatorApp.Controllers
{
    public class BMIController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BMICalculator model)
        {
            if (ModelState.IsValid)
            {
                model.BMI = model.Weight / (model.Height * model.Height);
                model.Category = GetBMICategory(model.BMI);

                ViewBag.Result = $"Chỉ số BMI của bạn là {model.BMI:F2}. {model.Category}";
            }
            return View(model);
        }

        private string GetBMICategory(double bmi)
        {
            if (bmi < 18.5) return "Dưới cân";
            if (bmi < 24.9) return "Bình thường";
            if (bmi < 29.9) return "Thừa cân";
            return "Béo phì";
        }
    }
}
