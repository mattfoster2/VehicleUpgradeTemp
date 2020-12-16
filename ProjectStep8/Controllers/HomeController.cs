using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectStep8.Models;
using System.Diagnostics;
using System.Linq;

namespace ProjectStep8.Controllers
{
   public class HomeController : Controller
   {
      // F i e l d s   &   P r o p e r t i e s 

      private IVehicleRepository _repository;

      // C o n s t r u c t o r s 
      public HomeController(IVehicleRepository repo)
      {
         _repository = repo;
      }

      //                M e t h o d s

      //  C r e a t e 

      //  R e a d 

      public IActionResult Index()
      {
         IQueryable<Vehicle> allVehicles = _repository.GetAllVehicles();
         return View(allVehicles);
      }
      public IActionResult Privacy()
      {
         return View();
      }

      //  U p d a t e 

      //  D e l e t e 

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
