using Microsoft.AspNetCore.Mvc;
using NewsMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsMvc.ViewComponents
{
    public class HeaderComponent :ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public HeaderComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }
    }
}
