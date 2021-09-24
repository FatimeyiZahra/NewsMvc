using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsMvc.Data;
using NewsMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsMvc.Controllers
{
    public class CategoryEditController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CategoryEditController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CategoryEditController
        public ActionResult Index()
        {
            var categories = _context.Categories.ToList();

            return View(categories);
        }

        // GET: CategoryEditController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (category == null)
            {
                return NotFound();

            }

            return View(category);
        }

        // GET: CategoryEditController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryEditController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        // GET: CategoryEditController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryEditController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryEditController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryEditController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
