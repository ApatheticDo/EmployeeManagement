
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.ViewModel;
using Microsoft.AspNetCore.Authorization;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;


public class LoginController : Controller
{
    private readonly EmployeeMngDbContext _context;

    public LoginController(EmployeeMngDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View("~/Views/Home/Login.cshtml");
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> AdminLogin(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var admin = await _context.Admins.FirstOrDefaultAsync(a => a.Admin_Name == model.Admin_Name.Trim() && a.Password == model.Password);
            if (admin != null)
            {
                HttpContext.Session.SetString("user", model.Admin_Name);
                HttpContext.Session.SetString("pass", model.Password);
                return RedirectToAction("Manage", "Home");
            }
            else
            {
                ViewBag.error = "Tai khoan hoac mat khau chua chinh xac";
                return View("~/Views/Home/Login.cshtml");
            }
        }
        ViewBag.error = "Thong tin khong hop le";
        return View("~/Views/Home/Login.cshtml"); 
    }


    public IActionResult AdminLogout()
    {
        HttpContext.Session.Remove("user");
        HttpContext.Session.Remove("pass");
        return View("~/Views/Home/Login.cshtml");
    }


}
