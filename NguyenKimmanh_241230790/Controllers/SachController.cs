using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenKimmanh_241230790.Models;
namespace NguyenKimmanh_241230790.Controllers
{
    public class SachController : Controller
    {
        private readonly QLNhaSachContext _context;

        public SachController(QLNhaSachContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.MaTL = new SelectList(
                await _context.TheLoais.ToListAsync(),
                "MaTl", "TenTl");

            return View(new SachCreateViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SachCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var sach = new Sach
                {
                    MaTl = model.MaTl!.Value,
                    TenSach = model.TenSach,
                    Gia = model.Gia,
                    Anh = model.Anh
                };

                _context.Saches.Add(sach);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }

            ViewBag.MaTL = new SelectList(
                await _context.TheLoais.ToListAsync(),
                "MaTl", "TenTl",
                model.MaTl);

            return View(model);
        }

    }
}

