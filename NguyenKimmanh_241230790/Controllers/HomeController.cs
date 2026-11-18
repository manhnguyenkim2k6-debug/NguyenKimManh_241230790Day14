using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using NguyenKimmanh_241230790.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;

namespace NguyenKimmanh_241230790.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> LocTheoLoai(int maTL){
            var ds = await _context.Saches.Where(s => s.MaTl == maTL).ToListAsync();
            return PartialView("_DanhSachSach", ds);
        }
        private readonly QLNhaSachContext _context;
        public HomeController(QLNhaSachContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dsSach = await _context.Saches.Where(s => s.Gia.HasValue && s.Gia > 100).ToListAsync();
            return View(dsSach);
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
}
