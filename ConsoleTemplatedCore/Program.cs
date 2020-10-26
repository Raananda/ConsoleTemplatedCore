using BusinessLogicLayer;
using BusinessLogicLayer.Services;
using DataAccessLayer;
using Infrastructure_Layer.Interfaces.Business_Logic;
using Infrastructure_Layer.Interfaces.Data_Access;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.IO;

namespace ConsoleTemplatedCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure builder
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);
            // Configure Serilog
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .CreateLogger();

            Log.Information("A P P    S T A R T");

            // Add DI services, serilog, build
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // App Layers
                    services.AddSingleton<IMainBusinessLogic, MainBusinessLogic>();
                    services.AddSingleton<IDataAccess, DataAccess>();

                    //Business Logic Services
                    services.AddTransient<IEmployeeService, EmployeeService>();
                    services.AddTransient<IPrintService, PrintService>();
                })
               .UseSerilog()
                .Build();



            var mainBusinessLogic = ActivatorUtilities.GetServiceOrCreateInstance<IMainBusinessLogic>(host.Services);

            //    var printService = ActivatorUtilities.GetServiceOrCreateInstance<IPrintService>(host.Services);
            mainBusinessLogic.Run();

            //   mainBusinessLogic = ActivatorUtilities.GetServiceOrCreateInstance<IMainBusinessLogic>(host.Services);

            //  mainBusinessLogic.Run();
            //   printService.Print("Hello service");
            Log.Information("A P P    F I N I S H");

        }

        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsetings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
                .AddEnvironmentVariables();
        }
    }
}
