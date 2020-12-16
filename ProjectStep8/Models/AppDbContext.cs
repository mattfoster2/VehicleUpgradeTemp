﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep8.Models
{
   public class AppDbContext : DbContext
   {
      // F i e l d s   &   P r o p e r t i e s 

      public DbSet<Vehicle> Vehicles { get; set; }

      public DbSet<User> Users { get; set; }

      public DbSet<Component> Components { get; set; }

      // C o n s t r u c t o r s 

      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
      {
      }

      // M e t h o d s 

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);

         modelBuilder.Entity<User>()
                     .HasIndex(u => u.EmailAddress)
                     .IsUnique(); 
      }
   }
}
