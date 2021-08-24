using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using SquaredClientApp.Contexts;
using SquaredClientApp.Services;
using SquaredClientApp.Interfaces;
using Microsoft.Extensions.Logging;

namespace SquaredClientApp
{
    public class Startup
    {
        public Startup()
        {
            var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            string connectionString = Configuration["connectionStrings:SqliteConnectionString"];
            string appPath = System.Windows.Forms.Application.StartupPath;
            services.AddDbContext<EmployeeContext>(o =>
            {
                o.UseSqlite(connectionString); // "Data Source=Database\\Expenses.db"
            });

            //register dependencies for injection
            services.AddLogging(configure => configure.AddEventLog())
                    .AddScoped<IEmployeeServiceRepo, EmployeeServiceRepo>()
                    .AddScoped<EmployeeMaintenance>()
                    .AddScoped<NewEmployeeForm>();
        }

        //This method gets called by the runtime.Use this method to configure the HTTP request pipeline.
        public void Configure()
        {
           
        }
    }
}
