using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuway
{
    /// <summary>
    /// Licenser middleware
    /// </summary>
    public class NuwayMiddleware
    {
        /// <summary>
        /// declare http request delegate
        /// </summary>
        private readonly RequestDelegate _next;

        /// <summary>
        /// Constructor function. Used to transfer parameters from parent pipeline
        /// </summary>
        /// <param name="next">http request delegate</param>
        public NuwayMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Listen for request information
        /// </summary>
        /// <param name="context">current httpcontext</param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
           await NuwayHandle.Handle(context,_next);
        }
    }
}
