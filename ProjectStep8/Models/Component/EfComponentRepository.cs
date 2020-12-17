using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep8.Models
{
   public class EfComponentRepository : IComponentRepository
   {
      // F i e l d s   &   P r o p e r t i e s

      private AppDbContext _context;
      private IVehicleRepository _vehicleRepository;
      private IUserRepository _userRepository;

      // C o n s t r u c t o r s 

      public EfComponentRepository(AppDbContext context, IVehicleRepository vehicleRepository, IUserRepository userRepository)
      {
         _context = context;
         _vehicleRepository = vehicleRepository;
         _userRepository = userRepository;
      }

                     // M e t h o d s 

      // C r e a t e 
      public Component AddMaintenance(Component c)
      {
         if (c == null)
         {
            return null;
         }
         Vehicle v = _vehicleRepository.GetVehicleById(c.VehicleId);
         if (v == null)
         {
            return null;
         }
         c.UserId = _userRepository.GetLoggedInUserId();
         _context.Components.Add(c);
         _context.SaveChanges();
         return c;
      }
      // R e a d 
      public IQueryable<Component> GetAllServices()
      {
         int userId = _userRepository.GetLoggedInUserId();
         return _context.Components.Where(c => c.UserId == userId); 
      }

      public Component GetComponentById(int id)
      {
         return _context.Components.Include(c => c.Vehicle).FirstOrDefault(c => c.Id == id);
      }
      // U p d a t e 
      public Component UpdateMaintenance(Component c)
      {
         if (c == null)
         {
            return null;
         }

         Component componentToUpdate = _context.Components.Find(c.Id);
         if (componentToUpdate != null)
         {
            componentToUpdate.ComponentName = c.ComponentName;
            componentToUpdate.ComponentCondition = c.ComponentCondition;
            componentToUpdate.ComponentCategory = c.ComponentCategory;
            componentToUpdate.ComponentCost = c.ComponentCost;
            componentToUpdate.ComponentManufacturer = c.ComponentManufacturer;
            componentToUpdate.AftermarketOrOem = c.AftermarketOrOem;
            componentToUpdate.LaborCost = c.LaborCost;
            componentToUpdate.PurchaseDate = c.PurchaseDate;
            componentToUpdate.PurchaseVendor = c.PurchaseVendor;
            componentToUpdate.ReplacedMileage = c.ReplacedMileage;
            componentToUpdate.WarrantyExpiration = c.WarrantyExpiration;
            componentToUpdate.Notes = c.Notes;
            if (c.VehicleId > 0)
            {
               componentToUpdate.VehicleId = c.VehicleId;
            }
            _context.SaveChanges();
         }
         return componentToUpdate;
      }
      // D e l e t e 
      public bool DeleteMaintenance(int id)
      {
         Component componentToDelete = GetComponentById(id);
         if (componentToDelete != null)
         {
            _context.Components.Remove(componentToDelete);
            _context.SaveChanges();
            return true;
         }
         return false;
      }
   }
}
