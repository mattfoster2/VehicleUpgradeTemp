using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep8.Models
{
   public class EfVehicleRepository : IVehicleRepository
   {
      // F i e l d s   &   P r o p e r t i e s

      private AppDbContext _context;
      private IUserRepository _userRepository;

      // C o n s t r u c t o r s 

      public EfVehicleRepository(AppDbContext context, IUserRepository userRepository)
      {
         _context = context;
         _userRepository = userRepository;
      }
      //                  C R U D   M e t h o d s

      //  C r e a t e 

      public Vehicle AddToGarage(Vehicle v)
      {
         v.UserId = _userRepository.GetLoggedInUserId();
         _context.Vehicles.Add(v);
         _context.SaveChanges();
         return v;
      }


      //  R e a d 
      public IQueryable<Vehicle> GetAllVehicles()
      {
         int userId = _userRepository.GetLoggedInUserId();
         return _context.Vehicles.Where(v => v.UserId == userId); //only returns for user that is logged in.
      }

      public Vehicle GetVehicleById(int id)
      {
         return _context.Vehicles.Include(v => v.Components).FirstOrDefault(v => v.Id == id); //best way
         //return _context.Vehicles.FirstOrDefault(v => v.Id == id);
      }

      //  U p d a t e 

      public Vehicle UpdateVehicle(Vehicle v)
      {
         Vehicle vehicleToUpdate = _context.Vehicles.Find(v.Id);

         if (vehicleToUpdate != null)
         {
            vehicleToUpdate.Year = v.Year;
            vehicleToUpdate.Make = v.Make;
            vehicleToUpdate.Model = v.Model;
            vehicleToUpdate.Trim = v.Trim;
            vehicleToUpdate.Mileage = v.Mileage;
            vehicleToUpdate.PurchaseDate = v.PurchaseDate;
            vehicleToUpdate.PurchasePrice = v.PurchasePrice;
            vehicleToUpdate.EngineType = v.EngineType;
            vehicleToUpdate.EngineDescription = v.EngineDescription;
            vehicleToUpdate.Horsepower = v.Horsepower;
            vehicleToUpdate.Torque = v.Torque;
            vehicleToUpdate.TransmissionType = v.TransmissionType;
            vehicleToUpdate.DrivetrainType = v.DrivetrainType;
            vehicleToUpdate.SteeringType = v.SteeringType;
            vehicleToUpdate.FrontSuspensionType = v.FrontSuspensionType;
            vehicleToUpdate.RearSuspensionType = v.RearSuspensionType;
            vehicleToUpdate.BrakeType = v.BrakeType;
            vehicleToUpdate.AboutVehicle = v.AboutVehicle;

            _context.SaveChanges();
         }
         return vehicleToUpdate;
      }

      //  D e l e t e 

      public bool DeleteVehicle(int id)
      {
         Vehicle vehicleToDelete = _context.Vehicles.Find(id);

         if (vehicleToDelete == null)
         {
            return false;
         }

         _context.Vehicles.Remove(vehicleToDelete);
         _context.SaveChanges();
         return true;
      }
   }
}
