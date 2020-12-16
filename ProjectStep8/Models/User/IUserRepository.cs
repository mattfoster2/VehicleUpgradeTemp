using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep8.Models
{
   public interface IUserRepository
   {
      // C r e a t e 

      public User AddUser(User u);

      // R e a d 
      public IQueryable<User> GetAllUsers(); //maybe
      public string GetLoggedInUserEmail(); 
      public User GetUserById(int id);
      public User GetUserByEmail(string userEmail);
      public bool Login(User u); //returns true or false for correct or incorrect password.
      public bool IsUserLoggedIn();
      public int GetLoggedInUserId();
      public bool IsUserAdmin();
      public void Logout(); 

      // U p d a t e

      public User UpdateUser(User u);

      // D e l e t e 

      public bool DeleteUser(int id);
      public bool DeleteUser(string userEmail);
   }
}
