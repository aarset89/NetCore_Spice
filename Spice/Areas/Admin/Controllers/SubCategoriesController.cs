using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.ViewModels;

namespace Spice.Areas.Customer.Controllers
{
    [Area("Admin")]
    public class SubCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var subcategories = _context.SubCategories.Include(s=>s.Category).ToList();

            //var viewModel = new 

            return View(subcategories);
        }

        public async Task<IActionResult> New()
        {
            var categories = _context.Categories.ToList();

            var viewModel = new SubCategoryViewModel
            {
                Categories = categories

            };

            return View("SubCategoriesForm", viewModel);
        }

        //[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(SubCategory subCategory)
        {
            ModelState.Remove("Id");

            if (!ModelState.IsValid)
            {
                var viewModel = new SubCategoryViewModel
                {
                    Categories = _context.Categories.ToList()
                };
                return View("SubCategoriesForm", viewModel);
            }

            if(subCategory.Id == 0)
            {
                _context.SubCategories.Add(subCategory);
            }
            else
            {
                var subCategoryInDb = await _context.SubCategories.SingleAsync(m => m.Id == subCategory.Id);

                subCategoryInDb.Name = subCategory.Name;
                subCategoryInDb.CategoryId = subCategory.CategoryId;

                _context.SubCategories.Update(subCategoryInDb);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int id)
        {
            var subCategory = await _context.SubCategories.SingleOrDefaultAsync(s => s.Id == id);
            if(subCategory == null)
            {
                return NotFound();
            }
            else
            {
                var viewModel = new SubCategoryViewModel
                {
                    SubCategory = subCategory,
                    Categories = _context.Categories.ToList()
                };
                return View("subCategoriesForm",viewModel);

            }

        }



        public async Task<IActionResult> Delete(int id)
        {
            var subCategory =await _context.SubCategories.SingleOrDefaultAsync(s => s.Id == id);
            if(subCategory==null)
            {
                return NotFound();
            }
            else
            {
                _context.SubCategories.Remove(subCategory);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

        }



        public IActionResult GetCategoryList(int id)
        {
            List<SubCategory> subCategories = new List<SubCategory>();

            subCategories = (from subCategory in _context.SubCategories
                                  where subCategory.CategoryId == id
                                  select subCategory).ToList();

            return Json(new SelectList(subCategories, "Id", "Name"));
        }
    }
}