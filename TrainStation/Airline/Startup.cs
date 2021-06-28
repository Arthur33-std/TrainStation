using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TrainStation.DAL;
using TrainStation.DAL.DBContext;
using TrainStation.DAL.Interfaces;
using TrainStation.DAL.Interfaces.IEntityRepositories;
using TrainStation.DAL.Repositories.EntityRepositories;
using TrainStation.DAL.UnitOfWork;
using TrainStation.BLL.Services;
using TrainStation.BLL.Interfaces.IServices;
using Microsoft.EntityFrameworkCore;
using TrainStation.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using FluentValidation;
using TrainStation.BLL.DTOs;
using TrainStation.BLL.Validation;
using AutoMapper;
using TrainStation.BLL;
using FluentValidation.AspNetCore;
using TrainStation.Filters;
using Microsoft.OpenApi.Models;
using System;

namespace TrainStation
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
            services.AddDbContext<TrainStationContext>(opts => opts.UseSqlServer(MyConnection.Connection));

            services.AddControllers();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<TrainStationContext>();

            #region Repositories
            services.AddTransient<IPassengerRepository, PassengerRepository>();
            services.AddTransient<IPassageScheduleRepository, PassageScheduleRepository>();
            services.AddTransient<IPassageRepository, PassageRepository>();
            #endregion

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #region Services
            services.AddTransient<IPassengerService, PassengerService>();
            services.AddTransient<IPassageScheduleService, PassageScheduleService>();
            services.AddTransient<IPassageService, PassageService>();
            #endregion

            services.AddAutoMapper(typeof(OrganizationProfile));

            #region FluentValidation

            services.AddMvc(setup =>
            {
                setup.Filters.Add(typeof(ValidatorActionFilter));
            }).AddFluentValidation();

            #region DTO Validators
            services.AddTransient<IValidator, PassengerDTOValidator>();
            services.AddTransient<IValidator, PassageDTOValidator>();
            #endregion

            #endregion
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "TrainStation API",
                    Description = "ASP.NET Core Web API"
                });

                c.IncludeXmlComments(GetXmlCommentsPath());
            });
        }
        private string GetXmlCommentsPath()
        {
            return string.Format(@"{0}\SwaggerTest.XML", AppDomain.CurrentDomain.BaseDirectory);
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
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My TrainStation API V1");

            });

        }
    }
}



