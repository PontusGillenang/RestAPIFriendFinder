using AutoMapper;
using FriendFinderAPI.Context;
using FriendFinderAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;

namespace FriendFinderAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FriendFinderContext>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IHobbyRepository, HobbyRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(Startup));

            services.AddMvc(options => options.EnableEndpointRouting=false)
                .SetCompatibilityVersion(Microsoft
                                        .AspNetCore
                                        .Mvc
                                        .CompatibilityVersion
                                        .Version_3_0);

            services.AddSwaggerGen(configure =>
            {
                configure.SwaggerDoc("v1", new OpenApiInfo { Title = "FriendFinderAPI", Version = "v1" });
                configure.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
                    {
                        Description = "Enter a valid key below.",
                        Name = "ApiKey",
                        In = ParameterLocation.Header,
                        Type = SecuritySchemeType.ApiKey,
                        Scheme = "apiKey"
                    });

                configure.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "ApiKey"
                            }
                        }, new List<string>()
                    }
                });
            });

                services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(configure =>
            {
                configure.SwaggerEndpoint("/swagger/v1/swagger.json", "FriendFinderAPI v1");
 
            });

            app.UseMvc();
        }
    }
}
