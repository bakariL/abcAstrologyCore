using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ckl.Areas.Identity.Services;
using ckl.Data;
using ckl.Models;
using ckl.Services.Helpers;
using ckl.Services.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SignalRChat.Hubs;


namespace ckl
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

            builder.AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        
            services.Configure<CookiePolicyOptions>(options =>
             {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                 options.MinimumSameSitePolicy = SameSiteMode.None;
             });
            var connectionString = Configuration.GetConnectionString("DefaultConnection");

            services.AddEntityFrameworkNpgsql()
                    .AddDbContext<ApplicationDbContext>(options => 
                    options.UseNpgsql(connectionString));      
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Stores.MaxLengthForKeys = 128;
                options.Password.RequiredLength = 8;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                //options.SignIn.RequireConfirmedEmail = true;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddRoles<IdentityRole>()
                .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
                // Default Lockout settings.
            {
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 100;
                options.Lockout.AllowedForNewUsers = true;
            });

            services.AddMvc(config => {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                       .Build();
               config.Filters.Add(new AuthorizeFilter(policy));
            });
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<ChatHub >();
            services.AddScoped<IPartnerTypeAssociationRepository, PartnerTypeAssociationRepository>();
            services.AddScoped<IPartnerRepository, PartnerRepository>();
            services.AddScoped<IHoroscopeRepository, HoroscopeRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<INewsLetterRepository, NewsLetterRepository>();
            services.AddScoped<ISaturnReportRepository, SaturnReportRepository>();
            services.AddScoped<IRequestRepository, RequestRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddSession();
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
              
              .AddSessionStateTempDataProvider();

            services.AddSignalR();
            services.AddSingleton<IUserIdProvider, CustomUserIdProvider>();
            services.AddAuthentication()
               .AddGoogle(googleOptions =>
               {
                   googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
                   googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];

               });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            var options = new RewriteOptions()
                .AddRedirectToHttpsPermanent();

            app.UseRewriter(options);

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseAuthentication();
            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHub>("/chatHub");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
