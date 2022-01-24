using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuway
{
    /// <summary>
    /// <para>service configure extension</para>
    /// </summary>
    /// <remarks> using this class static methods in startup class configure method. </remarks>
    public static class ServiceConfigureExtension
    {
        /// <summary>
        /// Add dependency injection
        /// </summary>
        /// <param name="service">startup service configure</param>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AddNuway(this IServiceCollection service)
        {
            return service.AddNuway(options => { });
        }
        /// <summary>
        /// Add dependency injection
        /// </summary>
        /// <param name="service">startup service configure</param>
        /// <param name="options">nuway options</param>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AddNuway(this IServiceCollection service,Action<NuwayOptions> options)
        {
            NuwayOptions nuwayOptions = new NuwayOptions();
            options(nuwayOptions);
            service.AddSingleton<NuwayOptions>(f => {
                return nuwayOptions;
            });
            return service;
        }
        /// <summary>
        /// Use Nuway middleware in your application
        /// </summary>
        /// <param name="app">current application object</param>
        /// <returns>IApplicationBuilder</returns>
        public static IApplicationBuilder UseNuway(this IApplicationBuilder app)
        {
            app.UseMiddleware<NuwayMiddleware>();
            return app;
        }
    }
}
