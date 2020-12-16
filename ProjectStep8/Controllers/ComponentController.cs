using Microsoft.AspNetCore.Mvc;
using ProjectStep8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep8.Controllers
{
   public class ComponentController : Controller
   {
      //  F i e l d s   &   P r o p e r t i e s 

      private IComponentRepository _repository;
      private IVehicleRepository _vehicleRepo;

      //  C o n s t r u c t o r s 

      public ComponentController(IComponentRepository repository, IVehicleRepository vehicleRepo)
      {
         _repository = repository;
         _vehicleRepo = vehicleRepo;
      }

                        //  M e t h o d s 

      //  C r e a t e 
      [HttpGet]
      public IActionResult AddComponent(int vehicleId)
      {
         Vehicle v = _vehicleRepo.GetVehicleById(vehicleId);
         Component c = new Component();
         c.Vehicle = v;
         c.VehicleId = vehicleId;
         return View(c);
      }

      [HttpPost]
      public IActionResult AddComponent(Component c)
      {
         if (ModelState.IsValid)
         {
            _repository.AddMaintenance(c);
            return RedirectToAction("VehicleDetail", "Vehicle", new { id = c.VehicleId });
         }
         return View(c);
      }
      //  R e a d 
      public IActionResult Index()
      {
         return View();
      }

      //  U p d a t e 

      [HttpGet]
      public IActionResult UpdateService(int id)
      {
         Component c = _repository.GetComponentById(id);
         if (c != null)
         {
            return View(c);
         }
         return RedirectToAction("VehicleDetail", "Vehicle");
      }
      [HttpPost]
      public IActionResult UpdateService(Component c, int id)
      {
         if (ModelState.IsValid)
         {
            c.Id = id;
            _repository.UpdateMaintenance(c);
            return RedirectToAction("VehicleDetail", "Vehicle", new { id = c.VehicleId });
         }
         else
         {
            return View(c);
         }
      }

      //  D e l e t e 
      public IActionResult DeleteService(int id)
      {
         _repository.DeleteMaintenance(id);
         return RedirectToAction("VehicleDetail", "Vehicle", new { id = id});
      }
   }
}
