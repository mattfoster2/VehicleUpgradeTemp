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
      public HomeController(ILogger<HomeController> logger, IVehicleRepository repo)
      {
         _repository = repo;
      }

      //                M e t h o d s

      //  C r e a t e 

      [HttpGet]
      public IActionResult AddVehicle()
      {
         return View();
      }
      [HttpPost]
      public IActionResult AddVehicle(Vehicle nv)
      {
         if (ModelState.IsValid)
         {
            _repository.AddToGarage(nv);
            return RedirectToAction("VehicleDetail", new { id = nv.Id });
            //return RedirectToAction("VehicleDetail", nv.Id);
         }
         else
         {
            return View(nv);
         }
      }

      //  R e a d 

      public IActionResult Index()
      {
         IQueryable<Vehicle> allVehicles = _repository.GetAllVehicles();
         return View(allVehicles);
      }

      public IActionResult VehicleDetail(int id)
      {
         Vehicle v = _repository.GetVehicleById(id);
         return View(v);
      }
      //public IActionResult VehicleDetail(Vehicle nv)
      //{
      //   return RedirectToAction("Index", nv);
      //}

      //  U p d a t e 

      [HttpGet]
      public IActionResult EditVehicle(int id)
      {
         Vehicle nv = _repository.GetVehicleById(id); 
         if (nv != null)
         {
            return View(nv);
         }
         return RedirectToAction("Index"); 
      }
      [HttpPost]
      public IActionResult EditVehicle(Vehicle v, int id)
      {
         if (ModelState.IsValid)
         {
            v.Id = id;
            _repository.UpdateVehicle(v);
            return RedirectToAction("Index");
         }
         else
         {
            return View(v);
         }
      }
      
      //  D e l e t e 

      public IActionResult DeleteVehicle(int id)
      {
         _repository.DeleteVehicle(id);
         return RedirectToAction("Index");
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
