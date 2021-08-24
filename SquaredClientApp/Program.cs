using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SquaredClientApp.Contexts;
using SquaredClientApp.Shared;
using Microsoft.Extensions.Logging;
using System.Threading;

namespace SquaredClientApp
{
    public class Program
    {
        static ILogger<Program> logger;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            
            IServiceCollection services = new ServiceCollection();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            //used in several places so moved to a shared class GetNewService
            //Startup startup = new Startup();
            //startup.ConfigureServices(services);
            //IServiceProvider serviceProvider = services.BuildServiceProvider();

            GetNewService.GetService<EmployeeContext>().ConfigureAwait(true);
            logger = GetNewService.GetRequiredService<ILogger<Program>>();


            //exception handle here for the whole application
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += new ThreadExceptionEventHandler(EmployeeMaintenance.HandleUIThreadException);

            // Add the event handler for handling non-UI thread exceptions to the event.
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            
            var employeeMaintForm = GetNewService.GetRequiredService<EmployeeMaintenance>();
            Application.Run(employeeMaintForm);  
        }

        //All non UI exceptions for the whole application will be handled here
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            logger.LogError((Exception) e.ExceptionObject, "Errors occurred check the log details.");
        }
    }
}
