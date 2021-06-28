using System.Configuration;
using Ies.Logo.Core.Configuration;
using Ies.Logo.Repositories;
using Ies.Logo.ServiceAdapter;
using Ies.SampleApp.Items;
using Microsoft.Extensions.DependencyInjection;

namespace Ies.SampleApp.DepedencyResolvers.Microsoft
{
    public static class Resolver
    {
        public static void Resolve(this IServiceCollection serviceProvider)
        {
            ResolveLogo(serviceProvider);

            serviceProvider
                .AddSingleton<IItemDal, ItemDal>()
                .AddSingleton<IItemService, ItemManager>()
                ;
        }
        static void ResolveLogo(IServiceCollection serviceProvider)
        {
            serviceProvider
                .AddSingleton<ILogoConnectionConfiguration>(o =>
                {
                    var configuration = new LogoConnectionConfiguration(ConfigurationManager.ConnectionStrings["Default"].ConnectionString)
                    {
                        FirmNumber = ConfigurationManager.AppSettings["FirmNumber"],
                        FirmPeriod = ConfigurationManager.AppSettings["FirmPeriod"],
                        SecurityCode = ConfigurationManager.AppSettings["SecurityCode"],
                        EndpointAddress = ConfigurationManager.AppSettings["EndpointAddress"]
                    };

                    return configuration;
                })
                .AddSingleton<ILogoObjectServiceConfiguration>(o => o.GetService<ILogoConnectionConfiguration>())
                .AddSingleton<ILogoConfiguration>(o => o.GetService<ILogoConnectionConfiguration>())
                .AddSingleton<ILogoObjectService, LogoObjectServiceAdapter>()
                .AddSingleton(typeof(ILogoRepository<>), typeof(LogoRepository<>));
        }
    }
}
