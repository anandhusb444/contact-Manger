using System.Diagnostics;
using System.Runtime.ExceptionServices;
using contact_Manger.Context;
using contact_Manger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace contact_Manger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ContactManagerContext _context;

        public HomeController(ILogger<HomeController> logger, ContactManagerContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
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

        [HttpGet]
        public async Task<IActionResult> Home()
        {
            try
            {
                int userId = HttpContext.Session.GetInt32("userId") ?? 0;

                var contacts = await _context.contacts.Where(c => c.UserId == userId).Include(c => c.user).ToListAsync();
                return View(contacts);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return NotFound();

            }
        }


        //public IActionResult Home()
        //{
        //    return View();
        //}



        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(Contact cont)
        {

            
                var isContactExist = await _context.contacts.FirstOrDefaultAsync(c => c.Name == cont.Name && c.Phone == cont.Phone);

                int userId = HttpContext.Session.GetInt32("userId") ?? 0;

                if (isContactExist == null)
                {
                    _context.contacts.Add(new Contact
                        {
                            Name = cont.Name,
                            Phone = cont.Phone,
                            Address = cont.Address,
                            DOB = cont.DOB,
                            Remark = cont.Remark,
                            UserId = userId
                        });

                    await _context.SaveChangesAsync();
                }
            
            return View();      
        }
    }
}
