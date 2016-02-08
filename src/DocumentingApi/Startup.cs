﻿using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DocumentingApi
{
	public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddMvc();
        }
		
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();

			app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
		
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
