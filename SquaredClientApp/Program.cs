using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TylerTechClientApp.Contexts;
using TylerTechClientApp.Services;

namespace TylerTechClientApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IServiceCollection services = new ServiceCollection();
            // Startup.cs finally :)
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<EmployeeContext>().ConfigureAwait(true);

            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeMaintenance(serviceProvider.GetService<IEmployeeServiceRepo>()));
        }

    }
}
