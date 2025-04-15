using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class DaiLyController : Controller
    {
        // GET: DaiLy
        public IActionResult Index()
        {
            // Giả sử bạn đã có một danh sách đại lý
            var daiLis = new List<DaiLy>
            {
                new DaiLy { MaDaiLy = "DL001", TenDaiLy = "Đại lý A", DiaChi = "Địa chỉ 1", NguoiDaiDien = "Người 1", DienThoai = "0123456789", MaHTPP = "HTPP01" },
                new DaiLy { MaDaiLy = "DL002", TenDaiLy = "Đại lý B", DiaChi = "Địa chỉ 2", NguoiDaiDien = "Người 2", DienThoai = "0987654321", MaHTPP = "HTPP02" }
            };

            return View(daiLis);
        }

        // GET: DaiLy/Details/5
        public IActionResult Details(string id)
        {
            // Giả sử bạn tìm thấy đại lý theo ID
            var daiLy = new DaiLy { MaDaiLy = "DL001", TenDaiLy = "Đại lý A", DiaChi = "Địa chỉ 1", NguoiDaiDien = "Người 1", DienThoai = "0123456789", MaHTPP = "HTPP01" };
            return View(daiLy);
        }
    }
}
