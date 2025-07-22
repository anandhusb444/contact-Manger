using contact_Manger.Context;
using contact_Manger.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Login(Users users)
        {

            if(ModelState.IsValid)
            {
                var isValidUser = _context.users.FirstOrDefault(user => user.Email == users.Email && user.Password == users.Password);

                if (isValidUser != null)
                {
                    Console.WriteLine("Valid user");
                    return RedirectToAction("Home");
                }
            }
            

            return View();
        }

    }
}
