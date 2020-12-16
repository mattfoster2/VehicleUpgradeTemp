using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStep8.Models
{
   public class EfUserRepository : IUserRepository
   {
      // F i e l d s   &   P r o p e r t i e s 

      private AppDbContext _context;
      private ISession     _session;

      // C o n s t r u c t o r s 

      public EfUserRepository(AppDbContext context, IHttpContextAccessor httpContextAccessor) //object to receive info about Http Request. for Session.
      {
         _context = context;
         _session = httpContextAccessor.HttpContext.Session;
      }

      // M e t h o d s 

      // C r e a t e 
      public User AddUser(User u)
      {
         try
         {
            u.Password = encrypt(u.Password);
            _context.Users.Add(u);
            _context.SaveChanges();            
         }
         catch (Exception e)
         {
            u.Id = -1;
         }
         u.Password = ""; //no longer need since it's in database.  Clear it out.  
         return u;
      }
      // R e a d 

      public IQueryable<User> GetAllUsers()
      {
         return _context.Users;
      }

      public User GetUserByEmail(string userEmail)
      {
         return _context.Users.FirstOrDefault(u => u.EmailAddress == userEmail);
      }

      public User GetUserById(int id)
      {
         return _context.Users.Find(id);
      }

      public string GetLoggedInUserEmail()
      {
         return _session.GetString("userEmail");
      }

      public bool Login(User u)
      {
         User dbUser = GetUserByEmail(u.EmailAddress); 

         if (dbUser == null)
         {
            return false;
         }
         u.Password = encrypt(u.Password);

         if (dbUser.Password == u.Password)
         {
            _session.SetInt32("userId", dbUser.Id); //Add some info about the user Id into Session.  Magical.
            _session.SetString("userEmail", dbUser.EmailAddress);
            if (dbUser.IsAdmin == true)
            {
               _session.SetInt32("userAdmin", 1);
            }
            else
            {
               _session.SetInt32("userAdmin", 0);
            }
            return true;
         }
         return false;
      }

      public bool IsUserLoggedIn()
      {
         int? userId = _session.GetInt32("userId");
         if (userId == null)
         {
            return false;
         }
         else
         {
            return true;
         }
      }

      public int GetLoggedInUserId()
      {
         int? userId = _session.GetInt32("userId");
         if (userId == null)
         {
            return -1;
         }
         else
         {
            return userId.Value; // Value is an int
         }
      }
 
      public bool IsUserAdmin()
      {
         if (_session.GetInt32("userAdmin") == 1)
         {
            return true;
         }
         return false;
      }

      public void Logout()
      {
         _session.Remove("userEmail");
         _session.Remove("userId");
         _session.Remove("userAdmin");
      }
      // U p d a t e 
      public User UpdateUser(User u)
      {
         User userToUpdate = _context.Users.Find(u.Id);

         if (userToUpdate != null)
         {
            userToUpdate.EmailAddress = u.EmailAddress;
            userToUpdate.FirstName = u.FirstName;
            userToUpdate.LastName = u.LastName;
            userToUpdate.Password = u.Password;
            _context.SaveChanges();
         }
         return userToUpdate;
      }

      // D e l e t e 
      public bool DeleteUser(int id)
      {
         User userToDelete = _context.Users.Find(id);

         if (userToDelete == null)
         {
            return false;
         }

         _context.Users.Remove(userToDelete);
         _context.SaveChanges();
         return true;
      }

      public bool DeleteUser(string userEmail)
      {
         throw new NotImplementedException();
      }

      private string encrypt(string password)
      {
         // Encrypt Password First
         SHA256 myHashingVar = SHA256.Create();
         byte[] passwordByteArray = Encoding.ASCII.GetBytes(password); //converts password to array of bytes
         byte[] hashedPasswordByteArray = myHashingVar.ComputeHash(passwordByteArray); //converts array of bytes to hashed password
         string hashedPassword = "";
         foreach (byte b in hashedPasswordByteArray)
         {
            hashedPassword += b.ToString("x2"); //converts ascii keys to string of hexidecimal
         }
         password = hashedPassword;
         return password;
      }
   }
}
