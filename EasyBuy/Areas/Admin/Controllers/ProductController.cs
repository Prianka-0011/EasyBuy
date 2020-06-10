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
            if (srcText != null)
            {
                srcText = srcText.ToLower();
                products = _context.Products.Include(c => c.Category).Where(c => c.Name.ToLower().Contains(srcText));
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
        public async Task<IActionResult> Create(Product productVm, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                var sameProductCheck = _context.Products.FirstOrDefault(c => c.Name == productVm.Name);
                if (sameProductCheck != null)
                {
                    TempData["create"] = "This Product All Ready Exist";
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
                TempData["create"] = "This Product successfuly Create";
                return RedirectToAction(nameof(Index));
            }
            return View(productVm);
        }
        //HttpGet For Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["Category"] = new SelectList(_context.Categories.ToList(), "Id", "Name");
            var product = _context.Products.Include(c => c.Category).FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        //HttpPost for Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product productVm, IFormFile image)
        {
            if (id != productVm.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var product1 = _context.Products.FirstOrDefault(c => c.Id == productVm.Id);
                var sameProductCheck = _context.Products.FirstOrDefault(c => c.Name == productVm.Name && c.Id != productVm.Id);

                if (sameProductCheck != null)
                {
                    if (image == null)
                    {
                        var productImageFind = _context.Products.FirstOrDefault(c => c.Id == id);
                        productVm.Image = productImageFind.Image;
                    }
                    if (image != null)
                    {
                        var imgPath = Path.Combine(_hosting.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                        await image.CopyToAsync(new FileStream(imgPath, FileMode.Create));
                        productVm.Image = "Images/"+image.FileName;
                    }
                    TempData["update"] = "This Product Name Already Exist";
                    return View(productVm);
                }
                if (image != null)
                {
                    var imgPath = Path.Combine(_hosting.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(imgPath, FileMode.Create));
                    productVm.Image = "Images/" + image.FileName;

                }
                if (image == null)
                {
                    var product = _context.Products.FirstOrDefault(c => c.Id == productVm.Id);
                    if (productVm.Image != null)
                    {
                        product.Image = productVm.Image;
                        product.Name = productVm.Name;
                        product.Price = productVm.Price;
                        product.PrevPrice = productVm.PrevPrice;
                        product.Quantity = productVm.Quantity;
                        product.Category = productVm.Category;
                        product.Description = productVm.Description;
                        product.Specification = productVm.Specification;
                        product.IsAviable = productVm.IsAviable;
                    }
                    else
                    {
                        product.Name = productVm.Name;
                        product.Price = productVm.Price;
                        product.PrevPrice = productVm.PrevPrice;
                        product.Quantity = productVm.Quantity;
                        product.Category = productVm.Category;
                        product.Description = productVm.Description;
                        product.Specification = productVm.Specification;
                        product.IsAviable = productVm.IsAviable;
                    }
                    _context.Products.Update(product);
                    await _context.SaveChangesAsync();
                    TempData["update"] = "This Product successfuly Update";
                    return RedirectToAction(nameof(Index));
                }
                product1.Image = productVm.Image;
                product1.Name = productVm.Name;
                product1.Price = productVm.Price;
                product1.PrevPrice = productVm.PrevPrice;
                product1.Quantity = productVm.Quantity;
                product1.Category = productVm.Category;
                product1.Description = productVm.Description;
                product1.Specification = productVm.Specification;
                product1.IsAviable = productVm.IsAviable;
                _context.Products.Update(product1);
                await _context.SaveChangesAsync();
                TempData["update"] = "This Product successfuly Update";
                return RedirectToAction(nameof(Index));

            }
            return View(productVm);
        }
        //HttpGet For Details
        [HttpGet]
        public IActionResult Details(int ?id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var product = _context.Products.Include(c=>c.Category).FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        //HttpGet for Delete
        [HttpGet]
        public IActionResult Delete(int ?id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var product = _context.Products.Include(c => c.Category).FirstOrDefault(p => p.Id == id);
            if (product==null)
            {
                return NotFound();
            }
            return View(product);
        }
        //HttpPost for Delete
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task< IActionResult >ConfirmDelete(int id)
        {
            var product =await _context.Products.FirstOrDefaultAsync(c => c.Id == id);
            if (product!=null)
            {

               _context.Products.Remove(product);
             await _context.SaveChangesAsync();
                TempData["delete"] = "This Product successfuly delete";
                return RedirectToAction(nameof(Index));
                
            }
            return View(product);  
        }
    }   
  }
