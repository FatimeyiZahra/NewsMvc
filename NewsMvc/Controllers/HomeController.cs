using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsMvc.Data;
using NewsMvc.Models;
using NewsMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NewsMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Categories = _context.Categories.ToList(),
                TopNews = _context.News.Include("Category").Where(t => t.IsTop).Take(4).ToList(),
                LastNews=_context.News.Include(p => p.Category).OrderByDescending(n=>n.Id).ToList(),
                AllNews=_context.News.Include("Category").OrderByDescending(n=>n.Id).ToList(),
            };

            return View(homeViewModel);
        }
    }
}
