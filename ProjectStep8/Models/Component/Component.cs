using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep8.Models
{
   [Table("Component")]
   public class Component
   {
      public int       Id                    { get; set; }
      [ForeignKey("ComponentCategory")]
      public int       CategoryId            { get; set; }
      [ForeignKey("Vehicle")]
      public int       VehicleId             { get; set; }
      public Vehicle   Vehicle               { get; set; }
      [ForeignKey("User")]
      public int       UserId                { get; set; }
      [Required(ErrorMessage = "Please create a component")]
      public string    ComponentName         { get; set; }
      [Required(ErrorMessage = "Please fill in the appropriate category")]
      public string    ComponentCategory     { get; set; }
      [Required(ErrorMessage = "Please enter current condition")]
      public string    ComponentCondition    { get; set; }
      public int       ReplacedMileage       { get; set; }
      [Column(TypeName = "date")]
      [DataType(DataType.Date)]
      [UIHint("date")]
      public DateTime? PurchaseDate          { get; set; }
      [Column(TypeName = "decimal(8, 2)")]
      public decimal   ComponentCost         { get; set; }
      public string    ComponentManufacturer { get; set; }
      public string    PurchaseVendor        { get; set; }
      [Column(TypeName = "decimal(8, 2)")]
      public decimal   LaborCost             { get; set; }
      public DateTime? WarrantyExpiration    { get; set; }
      public string    AftermarketOrOem      { get; set; }
      public string    Notes                 { get; set; }
      
   }
}
