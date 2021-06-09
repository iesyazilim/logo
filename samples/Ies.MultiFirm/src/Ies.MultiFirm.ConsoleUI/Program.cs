using System.Threading;
using Ies.Logo.Core.Security;
using Ies.MultiFirm.ClCards;
using Ies.MultiFirm.DepedencyResolvers.Microsoft;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ies.MultiFirm.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var scope1 = CreateDI();
            Thread.CurrentPrincipal = LogoClaimsHelper.CreatePrincipal("001", "01", "http://localhost/LogoObjectService/Service");
            var clCardService = scope1.GetService<IClCardService>();
            clCardService.PreviousFirmInfo();

            var scope2 = CreateDI();
            Thread.CurrentPrincipal = LogoClaimsHelper.CreatePrincipal("002", "01", "http://localhost/LogoObjectService/Service");
            var clCardService2 = scope2.GetService<IClCardService>();
            clCardService2.PreviousFirmInfo();
        }
        static ServiceProvider CreateDI()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IConfiguration, IConfigurationRoot>(o =>
            {
                return new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables()
                    .Build();
            });

            serviceCollection.Resolve();

            return serviceCollection.BuildServiceProvider();
        }
    }

}
