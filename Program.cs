using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Configuration;
using Turbo.az.DAL;
using Turbo.az.Extensions;
using Turbo.az.Models;

namespace Turbo.az
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContex>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<AppDbContex>().AddDefaultTokenProviders();

            builder.Services.AddScoped<Extensions.IEmailService , Extensions.EmailSender>();



            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false; //R?q?m t?l?b edin
                options.Password.RequireLowercase = false; //Kiçik h?rf t?l?b edin
                options.Password.RequireUppercase = false; //Böyük h?rf t?l?b edin
                options.Password.RequiredLength = 6; //T?l?b olunan uzunluq...
                options.Password.RequireNonAlphanumeric = false; //@ * ! ve.s kimi simvollar olmalidi
                options.Lockout.MaxFailedAccessAttempts = 10; //5 giri?ten sonra bloklanir 
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMilliseconds(5); //bloklamndiqdan 5deq sonra acilir
                options.Lockout.AllowedForNewUsers = true; //yeni qeydiyyat userdirse passwordu unuda biler.bir nece yazdiqda bloklamaya bilersiz
                options.User.AllowedUserNameCharacters =
             "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789._";//olmas?n? istediyiniz vacib karaterleri yazin
                options.User.RequireUniqueEmail = true; //unique emaail adresleri olsun (1emaille bir qeydiyyat)
                options.SignIn.RequireConfirmedEmail = true; //qeydiyyat etdikden sonra email ile token gönderecek 
                options.SignIn.RequireConfirmedPhoneNumber = false; //telefon do?rulamas?
            });



            var app = builder.Build();

           using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

                if(!await roleManager.RoleExistsAsync("Admin"))
                {
                    await roleManager.CreateAsync(new IdentityRole("Admin"));
                }

                if (!await roleManager.RoleExistsAsync("User"))
                {
                    await roleManager.CreateAsync(new IdentityRole("User"));
                }
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "admin",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
