using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.EntityFrameworkCore;
using ApnaGhar.Data;
using ApnaGhar.IServices;
using ApnaGhar.Services;

namespace ApnaGhar.Web.Api
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
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDBContext>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("ApnaGhar.Web.Api")));

            services.AddMvc();
            // Register Swagger Generator
            services.AddSwaggerGen(
                c =>
                {
                    c.SwaggerDoc("v1",
                        new Info
                        {
                            Title = "Test API",
                            Version = "v1",
                            Description = "A simple example ASP.NET Core Web API",
                            TermsOfService = "None",
                            Contact = new Contact { Name = "Waqas Rasheed", Email = "", Url = "https://twitter.com/WaqasRasheed14" },
                            License = new License { Name = "Use under LICX", Url = "https://jangoodev.com/license" }
                        }
                        );
                }
            );


            // register services
            services.AddTransient<IPropertyService, PropertyService>();
            services.AddTransient<IUserService, UserService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test API V1"); });

            app.UseMvc();
        }
    }
}
