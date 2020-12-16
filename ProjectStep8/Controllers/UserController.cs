using Microsoft.AspNetCore.Mvc;
using ProjectStep8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep8.Controllers
{
   public class UserController : Controller
   {
      // F i e l d s   &   P r o p e r t i e s

      private IUserRepository _repository;

      // C o n s t r u c t o r s 
      public UserController(IUserRepository repo)
      {
         _repository = repo;
      }

      //                M e t h o d s

      //  C r e a t e 
      [HttpGet]
      public IActionResult Register()
      {
         return View();
      }
      [HttpPost]
      public IActionResult Register(User newUser)
      {
         if (ModelState.IsValid)
         {
            _repository.AddUser(newUser);
            return RedirectToAction("Index", "Home");
            //return RedirectToAction("VehicleDetail", nv.Id);
         }
         else
         {
            return View(newUser);
         }
      }

      //  R e a d 

      [HttpGet]
      public IActionResult Login()
      {
         return View();
      }

      [HttpPost]
      public IActionResult Login(User u)
      {
         bool validUser = _repository.Login(u); 
         if (validUser == true)
         {
            return RedirectToAction("Index", "Home");
         }
         return View(u);
      }

      public IActionResult Logout()
      {
         _repository.Logout();
         return RedirectToAction("Index", "Home");
      }

      public IActionResult Index(int id)
      {
         User currentUser = _repository.GetUserById(id);
         return View(currentUser);
      }

      // U p d a t e 

      [HttpGet]
      public IActionResult EditUser(int id)
      {
         User newUser = _repository.GetUserById(id);
         if (newUser != null)
         {
            return View(newUser);
         }
         return RedirectToAction("Index");
      }
      [HttpPost]
      public IActionResult EditUser(User u, int id)
      {
         if (ModelState.IsValid)
         {
            u.Id = id;
            _repository.UpdateUser(u);
            return RedirectToAction("Index", "Home");
         }
         else
         {
            return View(u);
         }
      }

      //  D e l e t e 

      public IActionResult DeleteUser(int id)
      {
         _repository.DeleteUser(id);
         return RedirectToAction("Index", "Home");
      }
   }
}
