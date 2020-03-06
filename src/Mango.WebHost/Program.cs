using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using NLog.Web;
using System.Net;
namespace Mango.WebHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NLogBuilder.ConfigureNLog("nlog.config");
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders(); //�Ƴ��Ѿ�ע���������־�������
                    logging.SetMinimumLevel(LogLevel.Trace); //������С����־����
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //webBuilder.UseKestrel();
                    //webBuilder.ConfigureKestrel(serverOptions =>
                    //{
                    //    serverOptions.Listen(IPAddress.Loopback, 8080);
                    //    //
                    //    serverOptions.Listen(IPAddress.Loopback, 443, listenOptnios => {
                    //        listenOptnios.UseHttps("2336227_www.51core.net.pfx", "GWWXEFUe");
                    //    });
                    //});

                    webBuilder.UseUrls("http://*:8080");
                    webBuilder.UseStartup<Startup>();
                })
                
                .UseNLog();
    }
}
