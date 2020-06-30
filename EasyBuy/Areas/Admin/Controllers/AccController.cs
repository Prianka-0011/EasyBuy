using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyBuy.Data;
using EasyBuy.Models;
using EasyBuy.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EasyBuy.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _context;

        public AccController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context,

            ILogger<AccController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Register register)
        {
            if (ModelState.IsValid)
            {
                CustomerModel customer = new CustomerModel()
                {
                    FullName = register.FullName,
                    UserName = register.UserName,
                    Email = register.Email
                };
                _context.Add(customer);
                await _context.SaveChangesAsync();
                var user = new IdentityUser { UserName = register.UserName, Email = register.Email };
                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var callbackUrl = Url.Page(
                    //    "/Account/ConfirmEmail",
                    //    pageHandler: null,
                    //    values: new { userId = user.Id, code = code },
                    //    protocol: Request.Scheme);

                    //await _emailSender.SendEmailAsync(register.Email, "Confirm your email",
                    //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Login");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
                return View(register);

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(login.UserName, login.Password, login.RememberMe, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                   
                    var user = _context.Users.FirstOrDefault(c => c.UserName == login.UserName);
                    var role = _context.UserRoles.FirstOrDefault(c => c.UserId == user.Id);
                    if (role!=null)
                    {
                        var roleType = _context.Roles.FirstOrDefault(c => c.Id == role.RoleId);
                        if (roleType.Name == "Admin")
                        {
                            return RedirectToAction("Index", "Product");
                        }
                    }
                  
                    else
                    {
                        var customer = _context.Customers.Where(c => c.UserName == login.UserName).FirstOrDefault();

                        var customerId = customer.Id;
                        var customerName = customer.FullName;
                        HttpContext.Session.SetString("customerId", customerId);
                        HttpContext.Session.SetString("customerName", customerName);
                        return RedirectToAction("Index", "Home", new { area = "Customer" });

                    }
                }
            }
            return View(login);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult CreateRole()
        {

            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateRole(string RoleName)
        {
            string msg = "";
            if (!string.IsNullOrEmpty(RoleName))
            {
                if (await _roleManager.RoleExistsAsync(RoleName))
                {
                    msg = "Role " + RoleName + " Already exists";
                }
                else
                {
                    IdentityRole Role = new IdentityRole(RoleName);
                    await _roleManager.CreateAsync(Role);
                   TempData["create"] = "Role " + RoleName + " Successfully Created";

                }
                ViewBag.msg = msg;
                return View("CreateRole");
            }
            else
            {
                ViewBag.msg = "Please enter a valid role";
                return View("CreateRole");
            }

        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AssignRole()
        {
            var users = _userManager.Users;
            var roles = _roleManager.Roles;

            ViewBag.userlist = users;
            ViewBag.rolelist = roles;
            ViewBag.msg = TempData["msg"];

            return View();
        }
        //[Authorize(Roles = "Admin")]
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignRole(string appuser, string approle)
        {
            string msg = "";
            if (!string.IsNullOrEmpty(appuser) && !string.IsNullOrEmpty(approle))
            {
                var user = await _userManager.FindByNameAsync(appuser);
                if (user != null)
                {
                    IdentityRole role = await _roleManager.FindByNameAsync(approle);
                    if (role != null)
                    {
                        await _userManager.AddToRoleAsync(user, role.Name);
                        msg = role.Name + " has been assigned to user {" + user.UserName + "}.";
                    }
                    else
                    {
                        msg = "Role cannot be empty to assign to user.";
                    }
                }
                else
                {
                    msg = "Please select a User to assign Role.";
                }
            }
            else
            {
                msg = "Invalid User and/or Invalid Role.";
            }
            TempData["msg"] = msg;
            return RedirectToAction("AssignRole");

        }
        [Authorize(Roles = "Admin")]
        public IActionResult RegisteredUserIndex(string returnUrl = null)
        {
            var user = _context.Users.ToList();
            return View(user);
        }

    }
}