using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisabledConfidentWebsite.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DisabledConfidentWebsite
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

            services.AddDbContext<EmployerContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //// Use SQL Database if in Azure, otherwise, use SQLite
            //if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
            //    services.AddDbContext<MyDatabaseContext>(options =>
            //            options.UseSqlServer(Configuration.GetConnectionString("MyDbConnection")));
            //else
            //    services.AddDbContext<MyDatabaseContext>(options =>
            //            options.UseSqlite("Data Source=MvcMovie.db"));
            // Automatically perform database migration
            //services.BuildServiceProvider().GetService<MyDatabaseContext>().Database.Migrate();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Employers}/{action=Index}/{id?}");
            });
        }
    }
}
