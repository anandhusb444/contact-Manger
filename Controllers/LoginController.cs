using contact_Manger.Context;
using contact_Manger.Models;
using Microsoft.AspNetCore.Mvc;
using contact_Manger.DTOs;

namespace contact_Manger.Controllers
{
    public class LoginController : Controller
    {
        private readonly ContactManagerContext _context;
        public LoginController(ContactManagerContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserDto users)
        {

            if(ModelState.IsValid)
            {
                var isValidUser = _context.users.FirstOrDefault(user => user.Email == users.Email && user.Password == users.Password);

                HttpContext.Session.SetInt32("userId", isValidUser?.Id ?? 0);

                if (isValidUser != null)
                {
                    
                    return RedirectToAction("Home", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View();
                }
            }
            

            return View();
        }

    }
}
