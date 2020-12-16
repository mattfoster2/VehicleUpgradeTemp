using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep8.Models
{
   public interface IComponentRepository
   {
      // C r e a t e 
      public Component AddMaintenance(Component c);

      // R e a d 

      public IQueryable<Component> GetAllServices();

      public Component GetComponentById(int id);

      // U p d a t e

      public Component UpdateMaintenance(Component c);

      // D e l e t e 

      public bool DeleteMaintenance(int id);
   }
}
