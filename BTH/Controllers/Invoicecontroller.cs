using Microsoft.AspNetCore.Mvc;
using BTH.Models;

namespace BTH.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateInvoice(InvoiceModel model)
        {
            if (ModelState.IsValid)
            {
                model.TotalAmount = model.Quantity * model.UnitPrice;
                ViewBag.TotalAmount = model.TotalAmount;
            }
            return View("Index");
        }
    }
}

