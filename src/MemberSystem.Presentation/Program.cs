using MemberSystem.Application.Registers;
using MemberSystem.Infrastructure.Config;
using MemberSystem.Infrastructure.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MemberSystem.Web.Web
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<MemberContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("MemberContext")));

            builder.Services.Configure<ConnectionSettings>(builder.Configuration.GetSection("ConnectionStrings"));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddAuthentication(MemberSystemConfig.CookieScheme)
             .AddCookie(MemberSystemConfig.CookieScheme, options =>
             {
                 options.AccessDeniedPath = "/account/denied";
                 options.LoginPath = "/account/login";
             });
            builder.Services.AddSingleton<IConfigureOptions<CookieAuthenticationOptions>, ConfigureMyCookie>();

            builder.Services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining(typeof(Program));
            });

            ApplicationRegister.RegisterDapperTypeMap();
            builder.Services.RegisterQueriesServices();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            else
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}