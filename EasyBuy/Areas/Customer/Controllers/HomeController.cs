using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyBuy.Models;
using EasyBuy.Data;
using Microsoft.EntityFrameworkCore;
using EasyBuy.Utility;
using EasyBuy.ViewModels;

namespace EasyBuy.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string srcText)
        {
            IQueryable<Product> products = _context.Products.Include(c => c.Category);
            ViewBag.srcText = srcText;
            if (srcText != null)
            {
                srcText.ToLower();
                products = _context.Products.Where(c => c.Name.ToLower().Contains(srcText) || c.Category.Name.ToLower().Contains(srcText));
            }

            return View(products);
        }
        public IActionResult Cart()
        {
            List<CartItem> cartItem = HttpContext.Session.Get<List<CartItem>>("cart");
            List<CartItemVm> addItem = new List<CartItemVm>();
            if (cartItem!=null)
            {
                foreach (var item in cartItem)
                {
                    CartItemVm itemVm = new CartItemVm();
                  var cartProdut = _context.Products.Include(c => c.Category).FirstOrDefault(c => c.Id == item.ProductId);
                    itemVm.ProductId = item.ProductId;
                    itemVm.Quentity = item.Quantity;
                    itemVm.Name = cartProdut.Name;
                    itemVm.Price = cartProdut.Price;
                    itemVm.PrevPrice = cartProdut.PrevPrice;
                    itemVm.Category = cartProdut.Category.Name;
                    itemVm.Image = cartProdut.Image;
                    addItem.Add(itemVm);

                }
              
            }
            return View(addItem);
        }
        //HttpGet For Details
        [HttpGet]
        public IActionResult Details(int ?id)
        {
            if (id ==null)
            {
                return NotFound();
            }
            var products = _context.Products.Include(c => c.Category).FirstOrDefault(c => c.Id == id);
            if (products==null)
            {
                return NotFound();
            }
            return View(products);
        }
        //Shoping cart code
        //HttpGet for adtocart
        [HttpPost ,ActionName("Details")]
        [ValidateAntiForgeryToken]
        public IActionResult AddToCard(int id ,int quentity)
        {
            bool itemFound = false; 
            List<CartItem> cart = new List<CartItem>();
            var productItems = _context.Products.FirstOrDefault(c => c.Id == id);
            if (productItems == null)
            {
                return NotFound();
            }
            cart = HttpContext.Session.Get<List<CartItem>>("cart");
            if (cart!=null)
            {
                List<CartItem> newCart = new List<CartItem>();
                foreach (var item in cart)
                {
                    if (item.ProductId== productItems.Id)
                    {
                        itemFound = true;
                        item.Quantity=item.Quantity+quentity;
                    }
                    newCart.Add(item);
                }
                if (itemFound==false)
                {
                    var item = new CartItem();
                    item.ProductId = productItems.Id;
                    item.Quantity = quentity;
                    newCart.Add(item);
                }
                HttpContext.Session.Set<List<CartItem>>("cart", newCart);
                return RedirectToAction("Cart");
            }
            else
            {
                List<CartItem> newCart = new List<CartItem>();
                var item = new CartItem();
                item.ProductId = productItems.Id;
                item.Quantity = quentity;
                newCart.Add(item);
                HttpContext.Session.Set<List<CartItem>>("cart", newCart);
                return RedirectToAction("Cart");
            }
        }
        [HttpGet]
        public IActionResult IncCartItem(int?id)
        {

            if (id==null)
            {
                return NotFound();
            }
            List<CartItem> cartItem = HttpContext.Session.Get<List<CartItem>>("cart");
                List<CartItem> newCart = new List<CartItem>();
                foreach (var item in cartItem)
                {
                    if (item.ProductId == id)
                    {
                        item.Quantity++;
                    }
                    newCart.Add(item);
                }
                HttpContext.Session.Set<List<CartItem>>("cart", newCart);
                return RedirectToAction("Cart");
           
           
        }
        [HttpGet]
        public IActionResult DecCartItem(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            List<CartItem> cartItem = HttpContext.Session.Get<List<CartItem>>("cart");
            List<CartItem> newCart = new List<CartItem>();
            foreach (var item in cartItem)
            {
                if (item.ProductId == id)
                {
                    item.Quantity--;
                    if (item.Quantity==0)
                    {
                        cartItem.Remove(item);
                        HttpContext.Session.Set<List<CartItem>>("cart", newCart);
                        return RedirectToAction("Cart");
                    }
                }
                newCart.Add(item);
            }
            HttpContext.Session.Set<List<CartItem>>("cart", newCart);
            return RedirectToAction("Cart");
        }
        [HttpGet]
        public IActionResult RemoveCartItem(int ?id)
        {
            List<CartItem> cartItem = HttpContext.Session.Get<List<CartItem>>("cart");
            List<CartItem> newCart = new List<CartItem>();
            foreach (var item in cartItem)
            {
                if (item.ProductId == id)
                {
                   
                        cartItem.Remove(item);
                        HttpContext.Session.Set<List<CartItem>>("cart", cartItem);
                        return RedirectToAction("Cart");                 
                }
                
            }
            return RedirectToAction("Cart");
        }
        [HttpGet]
        public IActionResult CheckOut()
        {
            List<CartItem> cartItem = HttpContext.Session.Get<List<CartItem>>("cart");
           List<CartItemVm> addItem = new List<CartItemVm>();
            if (cartItem!=null)
            {
                foreach (var item in cartItem)
                {
                    CartItemVm itemVm = new CartItemVm();
                  var cartProdut = _context.Products.Include(c => c.Category).FirstOrDefault(c => c.Id == item.ProductId);
                    itemVm.ProductId = item.ProductId;
                    itemVm.Quentity = item.Quantity;
                    itemVm.Name = cartProdut.Name;
                    itemVm.Price = cartProdut.Price;
                    itemVm.PrevPrice = cartProdut.PrevPrice;
                    itemVm.Category = cartProdut.Category.Name;
                    itemVm.Image = cartProdut.Image;
                    addItem.Add(itemVm);

                }
                ViewBag.CheckOutItem = addItem;
              
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckOut(CheckOutVm checkOut)
        {
            List<CartItem> cartItem = HttpContext.Session.Get<List<CartItem>>("cart");
            List<CartItem> emptyobject = new List<CartItem>();


            if (ModelState.IsValid)
            {
                foreach (var item in cartItem)
                {
                    Order order = new Order();
                    order.FullName = checkOut.FullName;
                    order.PhoneNo = checkOut.PhoneNo;
                    order.Address = checkOut.Address;
                    order.ProductId = item.ProductId;
                    order.Quentity = item.Quantity;
                    _context.Orders.Add(order);
                    await _context.SaveChangesAsync();
                }
                
            }
             HttpContext.Session.Set<List<CartItem>>("cart", emptyobject);
            return View("Payment");
        }
        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
