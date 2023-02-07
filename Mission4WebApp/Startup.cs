using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4WebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();//add this to help with debugging
            }

            app.UseStaticFiles(); //startup class, configures the startup method

            app.UseRouting(); //added this
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default", //call this route "default" and go here if not find any other route (route is next line)
                    pattern: "{controller=Blah}/{action=Index}/{id?}" //what we'll see with default if they not type anything, go to blah controller; id? means it's nullable
                    );                                              //Index is the name in BlahController.cs file
            }
            );//This is a lambda function, more on this later ;this defines what they need to type to go to a certain point. Also, where they go when they type stuff
        }
    }
}
