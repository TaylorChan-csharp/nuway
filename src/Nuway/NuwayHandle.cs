using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuway
{
    public static class NuwayHandle
    {
        public static async Task Handle(HttpContext context,RequestDelegate next)
        {
            var option = context.RequestServices.GetService(typeof(NuwayOptions));
            await next(context);
        }
    }
}
