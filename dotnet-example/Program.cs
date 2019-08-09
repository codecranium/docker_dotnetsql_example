using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using System.Net;

namespace dotnet_example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();            
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseUrls("http://*:5000")
            // .UseUrls("http://*:5000", "https://*:5001")
            // .UseKestrel(options =>
            // {
            //     options.Listen(IPAddress.Loopback, 5000);  // http:localhost:5000
            //     // options.Listen(IPAddress.Loopback, 443, listenOptions =>
            //     // {
            //     //     listenOptions.UseHttps("certificate.pfx", "password");
            //     // });
            // })
            .UseStartup<Startup>()
            .Build();
    }
}
