using Clean_Store.Application.Interfaces.Contexts;
using Clean_Store.Application.Interfaces.FacadPatterns;
using Clean_Store.Application.Services.Products.FacadPattern;
using Clean_Store.Application.Services.Users.Commands.EditUser;
using Clean_Store.Application.Services.Users.Commands.RegisterUser;
using Clean_Store.Application.Services.Users.Commands.RemoveUser;
using Clean_Store.Application.Services.Users.Commands.UserLogin;
using Clean_Store.Application.Services.Users.Commands.UserStatusChange;
using Clean_Store.Application.Services.Users.Queries.GetRoles;
using Clean_Store.Application.Services.Users.Queries.GetUsers;
using Clean_Store.Persistence.Contexts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.LoginPath = new PathString("/");
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5.0);
            });

            services.AddScoped<IDatabaseContext, DatabaseContext>();
            services.AddScoped<IGetUsersService, GetUsersService>();
            services.AddScoped<IGetRolesService, GetRolesService>();
            services.AddScoped<IRegisterUserService, RegisterUserService>();
            services.AddScoped<IRemoveUserService, RemoveUserService>();
            services.AddScoped<IUserStatusChangeService, UserStatusChangeService>();
            services.AddScoped<IEditUserService, EditUserService>();
            services.AddScoped<IUserLoginService, UserLoginService>();

            //FacadInject
            services.AddScoped<IProductFacad, ProductFacad>();

            string connectionString = @"Data Source=DESKTOP-D5HAECB\MSSQLSERVER2019; Initial Catalog=Clean_StoreDb; Integrated Security=true;";
            services.AddEntityFrameworkSqlServer().AddDbContext<DatabaseContext>(option => option.UseSqlServer(connectionString));
            services.AddControllersWithViews();
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

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
