using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DisMu_Service.Discord;
using DisMu_Service.Manager;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DisMu_Service
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            try
            {
                SettingsManager.Init();

                if (SettingsManager.validSettings)
                {
                    DisMuBot.StartDisMuBot().GetAwaiter().GetResult();

                    if (DisMuBot.DisMuBotStarted)
                    {
                        CreateHostBuilder(args).Build().Run();
                        Thread.Sleep(-1);
                    } else
                    {
                        Console.WriteLine("Failed to start DisMu-Discord instance...\n-> Stopped...");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Settings detected...\n-> Stopping...");
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Exception in Program.Main: " + ex);
            }
            System.Environment.Exit(1);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                    .ConfigureKestrel((context, options) =>
                    {
                        options.Limits.MaxRequestHeaderCount = 1048576;
                        options.Limits.MaxRequestHeadersTotalSize = 1048576;
                    });
                });
    }
}
