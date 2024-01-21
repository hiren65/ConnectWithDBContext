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

            List<CFSPlanningReports> cfs = Context.CFSPlanningReports.Where(m => m.Order_Number == 1001026148.ToString()).Select(m => m).ToList();

            ViewBag.Customers = cfs.Count();

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

        public IActionResult Save()
        {
           CFSPlanningReports cfs = new CFSPlanningReports();
            cfs.Order_Number = "1001026148";
            cfs.Customer_Na = "Test";
            cfs.Description = "Test";
            cfs.QTY = "100";
            cfs.HOC_Date = "";
            cfs.CI_Date = "";
            cfs.CO_Date = "";
            cfs.CFS_Order_Status = "Dispatched";
            bool isExist = Context.CFSPlanningReports.Any(m => m.Order_Number == cfs.Order_Number);
            if (ModelState.IsValid)
            {
                if (isExist)
                {
                    cfs.Id = Context.CFSPlanningReports.Where(m => m.Order_Number == cfs.Order_Number).Select(m => m.Id).FirstOrDefault();
                    Context.CFSPlanningReports.Update(cfs);
                    ViewBag.Message = "Updated Successfully";
                }
                else
                {
                    Context.CFSPlanningReports.Add(cfs);
                    ViewBag.Message = "Added Successfully";
                }
                
                Context.SaveChanges();
            }

 
            return View("Index", new List<Received>());
        }

    }
}