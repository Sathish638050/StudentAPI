using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using StudentApi.Model;
using StudentApi.Repositary;
using StudentApi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApi
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
            services.AddDbContext<ELearnApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddCors();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "StudentApi", Version = "v1" });
            });
            services.AddScoped<IClass<Class>, Class>();
            services.AddScoped<IClassRepo<Class>, ClassRepo>();
            services.AddScoped<IClassServ<Class>, ClassServ>();

            services.AddScoped<IUserAccount<UserAccount>, UserAccount>();
            services.AddScoped<IUserAccountRepo<UserAccount>, UserAccountRepo>();
            services.AddScoped<IUserAccountServ<UserAccount>, UserAccountServ>();

            services.AddScoped<ICourse<Course>, Course>();
            services.AddScoped<ICourseRepo<Course>, CourseRepo>();
            services.AddScoped<ICourseServ<Course>, CourseServ>();

            services.AddScoped<ITopic<Topic>, Topic>();
            services.AddScoped<ITopicRepo<Topic>, TopicRepo>();
            services.AddScoped<ITopicServ<Topic>, TopicServ>();

            services.AddScoped<ICustomer<Customer>, Customer>();
            services.AddScoped<ICustomerRepo<Customer>, CustomerRepo>();
            services.AddScoped<ICustomerServ<Customer>, CustomerServ>();

            services.AddScoped<ICourseEnroll<CourseEnroll>, CourseEnroll>();
            services.AddScoped<ICourseEnrollRepo<CourseEnroll>, CourseEnrollRepo>();
            services.AddScoped<ICourseEnrollServ<CourseEnroll>, CourseEnrollServ>();     
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "StudentApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            loggerFactory.AddLog4Net();
            app.UseAuthorization();
            app.UseCors(options => options.WithOrigins().AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
