using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NguyenKimmanh_241230790.Models;
namespace NguyenKimmanh_241230790.ViewComponents
{
    public class TheLoaiMenuViewComponent : ViewComponent
    {
        private readonly QLNhaSachContext _context;
        public TheLoaiMenuViewComponent(QLNhaSachContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ds= await _context.TheLoais.ToListAsync();
            return View(ds);
        }
    }
}
