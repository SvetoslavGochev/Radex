namespace Radex.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Radex.Data;
    using Radex.Models.Api;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PreparateDatabase(this IApplicationBuilder app)
        {
            using var scopesScope = app.ApplicationServices.CreateScope();

            var services = scopesScope.ServiceProvider;

            MigrateDatabase(services);

            return app;
        }


        private static void MigrateDatabase(IServiceProvider services)
        {
            var data = services.GetRequiredService<Db>();
            data.Database.Migrate();
        }

       
    }
}
