using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var categoryDetails = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (categoryDetails == null)
            {
                return NotFound();
            }
            return View(categoryDetails);
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
            if (!_context.Categories.Any(x => x.Id == id))
            {
                return NotFound();
            }

            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: CategoryEditController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            if (!_context.Categories.Any(x => x.Id == id))
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Categories.Update(category);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Categories.Any(x => x.Id == id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        // GET: CategoryEditController/Delete/5
        public ActionResult Delete(int id)
        {
            if (!_context.Categories.Any(x => x.Id == id))
            {
                return NotFound();
            }
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);

            return View(category);
        }

        // POST: CategoryEditController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category category)
        {
            if (!_context.Categories.Any(x => x.Id == id))
            {
                return NotFound();
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}
