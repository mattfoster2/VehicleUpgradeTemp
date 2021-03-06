using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using ProjectStep8.Models;
using System;

namespace ProjectStep8
{
   public class Startup
   {
      // F i e l d s   &   P r o p e r t i e s 

      public IConfiguration Configuration { get; }

      // C o n s t r u c t o r s 
      public Startup(IConfiguration configuration)
      {
         Configuration = configuration;
      }   

      // M e t h o d s 

      // This method gets called by the runtime. Use this method to add services to the container.
      public void ConfigureServices(IServiceCollection services)
      {
         //services.AddDbContext<AppDbContext>(options => localdb
         //options.UseSqlServer
         //   (Configuration
         //       .GetConnectionString("DefaultConnection"))); 
         services.AddDbContext<AppDbContext>(options => //azuredb
         options.UseSqlServer
            (Configuration
                .GetConnectionString("DefaultConnection")));   //replace with ("AzureConnection")

         services.AddScoped<IVehicleRepository, EfVehicleRepository>();
         services.AddScoped<IUserRepository, EfUserRepository>();
         services.AddScoped<IComponentRepository, EfComponentRepository>();
         services.AddControllersWithViews().AddRazorRuntimeCompilation();

         services.AddMemoryCache(); //Session
         services.AddSession(
         //   options =>
         //   {
         //      options.IdleTimeout = TimeSpan.FromSeconds(10);
         //   }
         );
         services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
      }

      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
      {
         if (env.IsDevelopment())
         {
            app.UseDeveloperExceptionPage();
         }
         else
         {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
         }
         app.UseHttpsRedirection();
         app.UseStaticFiles();

         app.UseRouting();
         app.UseSession();

         app.UseAuthorization();

         app.UseEndpoints(endpoints =>
         {
            endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
         });
      }
   }
}
