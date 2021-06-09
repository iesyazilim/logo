using Ies.Logo.Core.Configuration;
using Ies.Logo.Repositories;
using Ies.Logo.ServiceAdapter;
using Ies.MultiFirm.ClCards;
using Ies.MultiFirm.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ies.MultiFirm.DepedencyResolvers.Microsoft
{
    public static class Resolver
    {
        public static void Resolve(this IServiceCollection serviceProvider)
        {
            ResolveLogo(serviceProvider);

            serviceProvider
                .AddSingleton<IClCardDal, ClCardDal>()
                .AddSingleton<IClCardService, ClCardManager>()
                ;
        }
        static void ResolveLogo(IServiceCollection serviceProvider)
        {
            serviceProvider
                .AddSingleton<ILogoExtendedConfiguration, LogoExtendedConfiguration>(o =>
                {
                    //var configuration = new LogoConnectionConfiguration(ConfigurationManager.ConnectionStrings["Default"].ConnectionString)
                    //{
                    //    FirmNumber = ConfigurationManager.AppSettings["FirmNumber"],
                    //    FirmPeriod = ConfigurationManager.AppSettings["FirmPeriod"],
                    //    SecurityCode = ConfigurationManager.AppSettings["SecurityCode"],
                    //    EndpointAddress = ConfigurationManager.AppSettings["EndpointAddress"]
                    //};

                    //return configuration;

                    return null;
                })
                .AddSingleton<ILogoConnectionConfiguration, ILogoExtendedConfiguration>(o => o.GetService<ILogoExtendedConfiguration>())
                .AddSingleton<ILogoObjectServiceConfiguration, ILogoExtendedConfiguration>(o => o.GetService<ILogoExtendedConfiguration>())
                .AddSingleton<ILogoConfiguration, ILogoExtendedConfiguration>(o => o.GetService<ILogoExtendedConfiguration>())
                .AddSingleton<ILogoObjectService, LogoObjectServiceAdapter>()
                .AddSingleton(typeof(ILogoRepository<>), typeof(LogoRepository<>));
        }
    }
}
