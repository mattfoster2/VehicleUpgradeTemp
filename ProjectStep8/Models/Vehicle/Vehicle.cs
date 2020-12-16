using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectStep8.Models
{
   [Table("Vehicle")]
   public class Vehicle
   {
      // F i e l d s   &   P r o p e r t i e s 

      public int Id { get; set; }

      [ForeignKey("User")]
      public int UserId { get; set; }

      [Required(ErrorMessage ="Year is Required")]
      public int Year { get; set; }

      [Required(ErrorMessage = "Make is Required")]
      public string Make { get; set; }

      [Required(ErrorMessage = "Model is Required")]
      public string Model { get; set; }
      public string Trim { get; set; }

      [Required(ErrorMessage = "Mileage is Required")]
      public int Mileage { get; set; }
      [Column(TypeName = "date")]
      [DataType(DataType.Date)]
      [UIHint("date")]

      public DateTime? PurchaseDate { get; set; }

      [Column(TypeName = "decimal(8, 2)")]
      public decimal PurchasePrice { get; set; }
      public string EngineType { get; set; }
      public string EngineDescription { get; set; }
      public string Horsepower { get; set; }
      public string Torque { get; set; }
      public string TransmissionType { get; set; }
      public string DrivetrainType { get; set; }
      public string SteeringType { get; set; }
      public string FrontSuspensionType { get; set; }
      public string RearSuspensionType { get; set; }
      public string BrakeType { get; set; }
      public string AboutVehicle { get; set; }
      public List<Component> Components { get; set; }

      //  C o n s t r u c t o r s 

      //  M e t h o d s 
   }
}
