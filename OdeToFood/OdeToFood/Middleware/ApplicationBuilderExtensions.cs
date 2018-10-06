using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Builder
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, String root )
        {
            var options = new StaticFileOptions();
            var path = Path.Combine(root, "node_modules");
            var fileprovider = new PhysicalFileProvider(path);

            options.RequestPath = "/node_modules";
            options.FileProvider = fileprovider;

            app.UseStaticFiles(options);
            return app;
        }
    }
}
