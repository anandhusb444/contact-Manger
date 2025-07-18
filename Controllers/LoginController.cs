using Microsoft.AspNetCore.Mvc;

namespace contact_Manger.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
