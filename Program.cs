/*
 * You will need to install the Microsoft.EntityFrameworkCore.SqlServer package using the following command.
 * Install-Package Microsoft.EntityFrameworkCore.SqlServer Or use Solution Explorer with the help of Nuget Package
 */
using ConnectWithDBContext.Models;
using Microsoft.EntityFrameworkCore;

namespace ConnectWithDBContext
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           var conStr = builder.Configuration.GetSection("ConnectionStrings").GetSection("DBConnect");
           builder.Services.AddDbContext<DBCtx>(options => options.UseSqlServer(conStr.Value));
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}