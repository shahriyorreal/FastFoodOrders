using FastFoodOrders.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FastFoodOrders.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoodRepository _logger;
        public HomeController(IFoodRepository logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ClientsIndex()
        {
            ClientViewModel viewModel = new ClientViewModel()
            {
                Clients = _logger.GetClients()
            };
            return View(viewModel);
        }

        public IActionResult FoodsIndex()
        {
            return View();
        }
        public IActionResult CreateFood() 
        {
            return View();  
        }

        [HttpGet]
        public ViewResult CreateClients()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateClients(Client client)
        {
            return View(client);
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


//try
//{
//    if (ModelState.IsValid)
//    {
//        var clients = new Client
//        {
//            Fullname = createViewModel.Fullname,
//            Username = createViewModel.Username,
//            Password = createViewModel.Password,
//            Phone = createViewModel.Phone
//        };
//        _logger.Clients.Add(clients);
//        _logger.SaveChanges();
//        return RedirectToAction("ClientsIndex");
//    }
//    else
//    {
//        TempData["errormessage"] = "XATO";
//        return View();
//    }
//}
//catch (Exception ex)
//{
//    TempData["errormessage"] = ex.Message;
//    return View();
//}
