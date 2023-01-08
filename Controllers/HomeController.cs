using ConnectWithDBContext.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConnectWithDBContext.Controllers
{
    public class HomeController : Controller
    {
       public DBCtx Context { get; }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DBCtx _context)
        {
            _logger = logger;
            Context = _context;
        }

        public IActionResult Index()
        {
            List<Received> customers = Context.tblReceived.Where(m=>m.TypeDeviceForSevice == "System").Select(m => m).Take(10).ToList();
            return View(customers);
            
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