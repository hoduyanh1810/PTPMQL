using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // GET: Hiển thị form nhập liệu
    public IActionResult Index()
    {
        return View();
    }

    // POST: Xử lý dữ liệu từ form
    [HttpPost]
    public IActionResult Index(string PersonID, string FullName, string Address)
    {
        // Xử lý dữ liệu form
        ViewBag.Message = $"Bạn đã nhập: PersonID = {PersonID}, FullName = {FullName}, Address = {Address}";

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
