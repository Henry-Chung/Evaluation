using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HenryChung.BudgetTracker.Core.RepositoryInterfaces;
using HenryChung.BudgetTracker.Core.ServiceInterfaces;
using HenryChung.BudgetTracker.Infrastructure.Data;
using HenryChung.BudgetTracker.Infrastructure.Repositories;
using HenryChung.BudgetTracker.Infrastructure.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HenryChung.BudgetTracker.MVC
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
            services.AddControllersWithViews();
            services.AddDbContext<BudgetTrackerDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BudgetTrackerDbConnection")));


            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IIncomesRepository, IncomesRepository>();
            services.AddScoped<IIncomesService, IncomesService>();
            services.AddScoped<IExpendituresRepository, ExpendituresRepository>();
            services.AddScoped<IExpendituresService, ExpendituresService>();
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
            }
            app.UseStaticFiles();

            app.UseRouting();

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
