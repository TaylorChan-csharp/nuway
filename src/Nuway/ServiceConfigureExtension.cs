using Microsoft.AspNetCore.Builder;
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
        /// Use Nuway in your application
        /// </summary>
        /// <param name="app">current application object</param>
        /// <returns>IApplicationBuilder</returns>
        public static IApplicationBuilder UseNuway(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
