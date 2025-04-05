using Microsoft.AspNetCore.Mvc;
using BTH.Models;

namespace BTH.Controllers
{
    public class BMIController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BMIModel model)
        {
            if (ModelState.IsValid)
            {
                // Lấy chỉ số BMI từ model (đã tính toán trong model)
                double bmi = model.BMI;
                string category = GetBMICategory(bmi);

                // Gửi kết quả BMI và phân loại về view
                ViewBag.BMIResult = $"Chỉ số BMI của bạn là: {bmi:F2} - {category}";
            }
            return View(model);
        }

        private string GetBMICategory(double bmi)
        {
            if (bmi < 18.5) return "Gầy";
            if (bmi < 24.9) return "Bình thường";
            if (bmi < 29.9) return "Thừa cân";
            return "Béo phì";
        }
    }
}
