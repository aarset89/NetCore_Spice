using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Spice.Data;
using Spice.Models;

namespace Spice.Areas.Customer.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }

        public IActionResult New()
        {
            return View("CategoriesForm");
        }

        //[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(Category category)
        {
            ModelState.Remove("Id");
            if (!ModelState.IsValid)
            {
                //var errors = ModelState.Values.SelectMany(v => v.Errors);
                return View("CategoriesForm", category);
            }

            if (category.Id == 0)
            {
                await _context.Categories.AddAsync(category);
            }
            else
            {
                var updateCategory = new Category();

                updateCategory = category;
                _context.Categories.Update(updateCategory);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("index");
        }

        //[HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _context.Categories.SingleOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            else
            {
                return View("CategoriesForm", category);

            }
        }

       //[HttpDelete
       //[ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.SingleOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }

        //[HttpGet]
        public IActionResult Details(int id)
        {
            var category = _context.Categories.SingleOrDefault(c => c.Id == id);

            if(category == null)
            {
                return NotFound();
            }

            return View(category);
        }

    }
}