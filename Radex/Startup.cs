namespace Radex
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.HttpsPolicy;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Radex.Data;
    using Radex.Infrastructure.Extensions;
    using Radex.Services.Candidate;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Radex.Services.Recruiter;
    using Radex.Services.Skills;

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
            services.AddControllersWithViews()
                .AddXmlSerializerFormatters();
            

            services.AddCors();// 4rez nego kazvame na brauzara koi moje da pravi zaqvki kam na6eto api
            services.AddDbContext<Db>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(Startup));
            //pravise kadeto spravim novi obekti i ne sme v select zaqvka
            //ako ima select zaqvka polzvame ProjectTo<>

            services.AddTransient<ICandidateServices, CandidateServices>();
            services.AddTransient<IRecruiterServices, RecruiterServices>();
            services.AddTransient<ISkillsServices, SkillsServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //using (IServiceScope serviceScope = app.ApplicationServices.CreateScope())
            //{
            //    Db dbContext = serviceScope.ServiceProvider.GetRequiredService<Db>();

            //        dbContext.Database.Migrate(); // Apply migration/seed everytime (for development purposes)

                
            //}
            app.PreparateDatabase();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors(policy =>
            {
                policy.WithOrigins("https://mysite.com").AllowAnyMethod().AllowAnyHeader();
                policy.WithOrigins("https://github.com").WithMethods("POST").AllowAnyHeader();
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //myRoute
                endpoints.MapControllerRoute(
                    "gg", "Blog/{year}/{month}/{day}",
                    new { controller = "Test", action = "GetName" },
                    new { year = @"[0-9]{4}"}//google haresva tova indeksira gi dobre

                    );
                ///adresa trqbva da zapo4va s Blog/2020/10/27 i da se vkarat parametrite v controlera int date int mesec int day
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
