using System.Linq;

namespace ProjectStep8.Models
{
   public interface IVehicleRepository
   {
      // C r e a t e 

      public Vehicle AddToGarage(Vehicle v);

      // R e a d 

      public IQueryable<Vehicle> GetAllVehicles();

      public Vehicle GetVehicleById(int id);

      // U p d a t e

      public Vehicle UpdateVehicle(Vehicle v);

      // D e l e t e 

      public bool DeleteVehicle(int id);
      
   }
}
