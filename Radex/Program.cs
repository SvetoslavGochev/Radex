namespace Radex
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
//with .Select => anonim type
//1(+) naav propart acess in lamba expre
//2.(+) get only the columns we need
//3.(-) no update, delet

//without .Select() => orig entity
//1. (i) No acess to nav propart(?) => polzvame Include() lazi loadinfg
//2.Get All Columns for entity
//3. (+) update/delete entity/ SaveChanges

