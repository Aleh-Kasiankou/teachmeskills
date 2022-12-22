using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpDesk.Persistence;
using HelpDesk.Services.TicketAutoAssigner;
using HelpDesk.Services.TicketCreateHandler;
using HelpDesk.Services.TicketUpdateHandler;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HelpDesk
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
            services.AddControllersWithViews();
            services.AddDbContext<HelpDeskDbContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("default")));

            services.AddScoped<ITicketUpdateHandler, TicketUpdateHandler>();
            services.AddScoped<ITicketCreateHandler, TicketCreateHandler>();
            services.AddScoped<ITicketAutoAssigner, TicketAutoAssigner>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "Customer Ticket Details",
                    "{controller=CustomerTickets}/{action=TicketDetails}/{id:guid}");

                endpoints.MapControllerRoute(
                    "Support Ticket Details",
                    "{controller=SupportTickets}/{action=TicketDetails}/{id:guid}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}