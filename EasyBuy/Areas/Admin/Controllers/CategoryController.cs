using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EasyBuy.Data;
using EasyBuy.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyBuy.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private ApplicationDbContext _context;
        private IHostingEnvironment _hosting;
        public CategoryController(ApplicationDbContext context, IHostingEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
        }
        public IActionResult Index()
        {
            var category = _context.Categories.ToList();
            return View(category);
        }
        //HttpGet For Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //HttpPost for Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Create(Category category,IFormFile image)
        {
            if (ModelState.IsValid)
            {
                //For  Redandent category Name do not Create
                var sameCatCheck = _context.Categories.FirstOrDefault(c => c.Name == category.Name );
                if (sameCatCheck!=null)
                {
                    TempData["create"] = "This Category All Ready Exist";
                    return View(category);
                }
                if (image!=null)
                {
                    var imgPath = Path.Combine(_hosting.WebRootPath +"/Images",Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(imgPath,FileMode.Create));
                    category.Image = "Images/"+image.FileName;
                }
                if (image==null)
                {
                    category.Image = "Images/noimage.jpg";
                }
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        //HttpGet for Edit
        [HttpGet]
        public IActionResult Edit(int ?id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            return View(category);
        }
        //HttpPost for Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(int id,Category categoryVm,IFormFile image)
        {
            if (id != categoryVm.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {  
                var categorySameName = _context.Categories.FirstOrDefault(c => c.Name == categoryVm.Name && c.Id != categoryVm.Id);
                //For  Redandent category Name do not update
                if (categorySameName != null )
                {
                    if (image==null)
                    {
                        var imageFind = _context.Categories.FirstOrDefault(c => c.Id == categoryVm.Id);
                        categoryVm.Image=imageFind.Image;
                    }
                    TempData["create"] = "This Category All Ready Exist";
                    return View(categoryVm);
                }
                if (image!=null)
                {
                    var imgPath = Path.Combine(_hosting.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(imgPath, FileMode.Create));
                    categoryVm.Image = "Images/"+image.FileName;
                }
                // Image not want to edit
                if (image==null)
                {
                    var imageFind = _context.Categories.FirstOrDefault(c => c.Id == categoryVm.Id);
                    imageFind.Name = categoryVm.Name;
                    _context.Categories.Update(imageFind);
                    await _context.SaveChangesAsync();
                    TempData["update"] = "This Product successfuly update";
                    return RedirectToAction(nameof(Index));
                }
                var category = _context.Categories.FirstOrDefault(c => c.Id == categoryVm.Id);
                category.Name = categoryVm.Name;
                category.Image = categoryVm.Image;
                _context.Categories.Update(category);
                await _context.SaveChangesAsync();
              return  RedirectToAction(nameof(Index));
            }
            return View(categoryVm);
        }
        //HttpGet For Details
        [HttpGet]
        public IActionResult Details(int?id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category==null)
            {
                return NotFound();
            }
            return View(category);
        }
        //HttpGet for Delete
        [HttpGet]
        public IActionResult Delete(int ? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category==null)
            {
                return NotFound();
            }

            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category==null)
            {
                return NotFound();
            }
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}