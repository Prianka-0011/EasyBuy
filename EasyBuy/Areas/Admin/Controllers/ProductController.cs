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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EasyBuy.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;
        private IHostingEnvironment _hosting;
        public ProductController(ApplicationDbContext context, IHostingEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
        }
        public IActionResult Index(string srcText)
        {
            IQueryable<Product> products = _context.Products.Include(c => c.Category);
            ViewBag.srcText = srcText;
            if (srcText!=null)
            {
                srcText = srcText.ToLower();
                products = _context.Products.Include(c => c.Category).Where(c=>c.Name.ToLower().Contains(srcText));
            }
           
            //ViewData["Category"] = new SelectList(_context.Categories.ToList(), "Id", "Name");
            return View(products);
        }
        //HttpGet for Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Category"] = new SelectList(_context.Categories.ToList(), "Id", "Name");
            return View();
        }
        //httpPost for Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Create(Product productVm,IFormFile image)
        {
            if (ModelState.IsValid)
            {
                var sameCatCheck = _context.Products.FirstOrDefault(c => c.Name == productVm.Name);
                if (sameCatCheck != null)
                {
                    TempData["create"] = "This Category All Ready Exist";
                    return View(productVm);
                }
                if (image != null)
                {
                    var imgName = Path.Combine(_hosting.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(imgName, FileMode.Create));
                    productVm.Image = "Images/" + image.FileName;
                }
                if (image == null)
                {
                    productVm.Image = "Images/noimage.jpg";
                }
                _context.Products.Add(productVm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
         
    }
}