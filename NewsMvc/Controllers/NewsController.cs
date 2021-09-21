﻿using Microsoft.AspNetCore.Mvc;
using NewsMvc.Data;
using NewsMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace NewsMvc.Controllers
{
    public class NewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("news-details")]
        public IActionResult NewsDetails(int Id)
        {
            if (!_context.News.Any(x => x.Id == Id))
            {
                return RedirectToAction("index", "error");
            }

            NewsSingleViewModel newsSingleViewModel = new NewsSingleViewModel
            {
                Categories = _context.Categories.ToList(),
                NewsDetails = _context.News.Include("Category").FirstOrDefault(x => x.Id == Id)

            };
            return View(newsSingleViewModel);
        }
    }
}