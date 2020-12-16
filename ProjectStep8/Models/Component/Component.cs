using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep8.Models
{
   [Table("Component")]
   public class Component
   {
      public int       Id                    { get; set; }
      public int       CategoryId            { get; set; }
      [ForeignKey("Vehicle")]
      public int       VehicleId             { get; set; }
      public Vehicle   Vehicle               { get; set; }
      [ForeignKey("User")]
      public int       UserId                { get; set; }
      public string    ComponentName         { get; set; }
      public string    ComponentCategory     { get; set; }
      public string    ComponentCondition    { get; set; }
      public int       ReplacedMileage       { get; set; }
      public DateTime? PurchaseDate          { get; set; }
      public decimal   ComponentCost         { get; set; }
      public string    ComponentManufacturer { get; set; }
      public string    PurchaseVendor        { get; set; }
      public decimal   LaborCost             { get; set; }
      public DateTime? WarrantyExpiration    { get; set; }
      public string    AftermarketOrOem      { get; set; }
      
   }
}
