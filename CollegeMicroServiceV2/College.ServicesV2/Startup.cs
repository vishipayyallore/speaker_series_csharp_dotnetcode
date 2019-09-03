using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using College.ServicesV2.BAL;
using College.ServicesV2.Common;
using College.ServicesV2.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace College.ServicesV2
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Adding EF Core
            var connectionString = Configuration[Constants.ConnectionString];
            services.AddDbContext<CollegeDbContext>(o => o.UseSqlServer(connectionString));


            // Application Services
            //TODO: THIS SHOULD BE DONE USING INTERFACES
            services.AddScoped<ProfessorsBal>();
            services.AddScoped<ProfessorsDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
