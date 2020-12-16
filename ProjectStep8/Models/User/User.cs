using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep8.Models
{
   [Table("User")]
   public class User
   {
      // F i e l d s   &   P r o p e r t i e s

      public int     Id           { get; set; }
      [Required(ErrorMessage = "Email Address is Required")]
      [EmailAddress]
      [MinLength(10)]
      [UIHint("email")] //like type = in cshtml
      public string  EmailAddress { get; set; }
      [Required(ErrorMessage = "First Name is Required")]
      public string  FirstName    { get; set; }
      [Required(ErrorMessage = "Last Name is Required")]
      public string  LastName     { get; set; }
      [Required(ErrorMessage = "You Must Set a Password")]
      [UIHint("password")]
      public string  Password     { get; set; }
      public bool    IsAdmin      { get; set; } = false;

      //  C o n s t r u c t o r s 

      //  M e t h o d s 
   }
}
