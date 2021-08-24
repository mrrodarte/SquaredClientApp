using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquaredClientApp.Shared
{
    public static class GetNewService
    {
        //use this methods in several parts of the application so move them to a shared class
        public static T GetRequiredService<T>()
        {
            //retrieve a new service instantiated with dependency injection
            IServiceCollection services = new ServiceCollection();
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            return serviceProvider.GetRequiredService<T>();
        }

        public static T GetService<T>()
        {
            IServiceCollection services = new ServiceCollection();
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            return serviceProvider.GetService<T>();
        }
    }
}
