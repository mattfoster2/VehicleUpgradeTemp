using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep8.Models.Component_Category
{
   [Table("ComponentCategory")]
   public class ComponentCategory
   {    
      public int Id { get; set; }
      public string CategoryName { get; set; }
   }
}
