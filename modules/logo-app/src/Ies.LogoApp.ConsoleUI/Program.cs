using System;
using System.Threading;
using System.Threading.Tasks;
using Ies.Logo.Core.Security;
using Ies.LogoApp.Items;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ies.LogoApp
{
    class Program
    {
        static IServiceProvider resolver { get; } = CreateDI();

        static async Task Main(string[] args)
        {
            Thread.CurrentPrincipal = LogoClaimsHelper.CreatePrincipal("998", "01", "http://localhost/LogoObjectService/Service");
            await Items();
        }
        static async Task Items()
        {
            var itemService = resolver.GetRequiredService<IItemService>();
            var items = await itemService.GetListAsync(new Entities.ListRequestDto());
            var itemPagedList = await itemService.GetPageListAsync(new Entities.DetailedPagedRequestDto());
        }

        static IServiceProvider CreateDI()
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IConfiguration, IConfigurationRoot>(o =>
            {
                return new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables()
                    .Build();
            });

            serviceCollection.ResolveLogoApp(ServiceLifetime.Scoped);

            return serviceCollection.BuildServiceProvider();
        }
    }
}
