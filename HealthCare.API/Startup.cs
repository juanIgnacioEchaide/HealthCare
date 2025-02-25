using HealthCare.API.Data;
using HealthCare.API.Interfaces;
using HealthCare.API.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HealthCare.API
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
            services.AddControllers();
            services.AddDbContext<DataContext>(x=>x.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddCors();
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            services.AddScoped<IPatientRepository,PatientRepository>();
            services.AddScoped<IPhysicianRepository,PhysicianRepository>();
            services.AddScoped<ITechnicianRepository,TechnicianRepository>();
            services.AddScoped<IMedicalRecordRepository,MedicalRecordRepository>();
            services.AddScoped<IMedicalRegistryRepository,MedicalRegistryRepository>();
            services.AddScoped<IHealthCareProviderRepository,HealthCareProviderRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }else{
                app.UseExceptionHandler("/Error");
                app.UseHsts();  
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x=> x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); 
         
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
