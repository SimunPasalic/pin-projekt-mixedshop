using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MixedShop.Interfaces;
using MixedShop.Models;
using MixedShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MixedShop
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;

        public Startup(IConfiguration configuration, IHostEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();



            services.AddSession(opts =>
            {
                opts.Cookie.IsEssential = true;
            });//ck

            services.AddTransient<IItemRepository, ItemRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            //2
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ShoppingCart>(sc=> ShoppingCart.GetCart(sc));
            services.AddTransient<IOrderRepository, OrderRepository>();
            //
            services.AddMemoryCache();
            services.AddSession();

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

            //
            AuthAppBuilderExtensions.UseAuthentication(app);

            app.UseAuthorization();

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            //
            app.UseSession();

            



            app.UseEndpoints(endpoints =>
            {
            endpoints.MapControllerRoute(
                name: "categoryFilter",
                pattern: "Item/{action}/{category?}",
                defaults: new { Controller = "Item", Action = "List" });
                    

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
