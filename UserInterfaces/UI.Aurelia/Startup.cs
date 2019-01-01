using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBase.EfSqlRepository.Interfaces;
using ComicBase.EfSqlRepository.Repository;
using ComicBase.OnlineComicApiProvider.Factory;
using ComicBase.OnlineComicApiProvider.Interfaces;
using ComicBase.Spa.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ComicBase
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
            services.AddMvc()
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                    options.SerializerSettings.Formatting = Formatting.Indented;
                });

            services.Configure<AppConfig>(Configuration.GetSection("AppConfig"));

            var connection = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ComicBaseContext>(options => options.UseSqlServer(connection));

            services.AddTransient(typeof(IComicBaseRepositoryFactory), typeof(ComicBaseRepositoryFactory));
            services.AddTransient(typeof(IOnlineComicProviderFactory), typeof(OnlineCatalogProviderFactory));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
