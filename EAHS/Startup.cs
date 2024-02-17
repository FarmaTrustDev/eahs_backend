using CGT_API.Infrastructures;
using EAHS.Helper;
using EAHS.Infrastructure;
using EAHS.Repositories;
using EAHS.SignlerProvateChannel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAHS
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
            services.AddDbContext<EAHSDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            // var sqlConnectionString = Configuration["PConnectionstrings:PostgreSqlConnectionString"];
            services.AddSingleton(Configuration.GetSection("AppConfiguration").Get<AppConfiguration>());
            services.AddControllers();
            /*services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EAHS", Version = "v1" });
            });*/
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ITokenProvider, TokenProvider>();
            ServiceConfiguration.Register(services);
            services.AddCors();

            //services.AddSignalR();

            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CGT_API", Version = "v2" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,

                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                {
                   new OpenApiSecurityScheme
                   {
                     Reference = new OpenApiReference
                    {
                       Type = ReferenceType.SecurityScheme,
                       Id = "Bearer"
                     }
                    },
                    new string[] { }
                  }
                });
            });
            services.AddSingleton<IUserConnectionManager, UserConnectionManager>();

            ServiceProviderResolver.ServiceProvider = services.BuildServiceProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EAHS v1"));
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
