using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using YummyRestApi.Models;

namespace YummyRestApi
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
            services.AddDbContext<RecipeContext>(opt =>
            opt.UseInMemoryDatabase("RecipeList"));
            //services.AddDbContext<RecipeContext>
            //      (options => options.UseSqlServer(Configuration.GetConnectionString("CrystalProcessDatabase")));
            //HACK 
            //IServiceProvider serviceProvider = services.BuildServiceProvider();
            //var env = serviceProvider.GetService<IHostingEnvironment>();
            ////logic in here to configure correct DB 
            //if (env.IsEnvironment("IntegrationTests"))
            //{
            //    services.AddEntityFrameworkInMemoryDatabase();

            //    services.AddDbContext<ApplicationDbContext>(options =>
            //    {
            //        options.UseInMemoryDatabase("InMemoryDbForTesting");
            //    });
            //}
            //else
            //{
            //    services.AddDbContext<ApplicationDbContext>
            //        (options => options.UseSqlServer(Configuration.GetConnectionString("CrystalProcessDatabase")));

            //}

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
