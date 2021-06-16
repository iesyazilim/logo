using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using Ies.Logo.Core.Configuration;
using Ies.Logo.Manager;
using Ies.Logo.Repositories;
using Ies.Logo.ServiceAdapter;
using Ies.LogoApp.Items;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ies.LogoApp.Resolver.Microsoft
{
    public static class Resolver
    {
        public static void ResolveLogoApp(this IServiceCollection serviceProvider, ServiceLifetime serviceLifetime, params LogoConnectionConfiguration[] configurations)
        {
            if (configurations == null || configurations.Length == 0)
            {
                serviceProvider.AddSingleton(o =>
                {
                    var configuration = o.GetService<IConfiguration>();
                    var firms = new List<LogoConnectionConfiguration>();
                    configuration.Bind("Firms", firms);
                    return firms;
                });
            }
            else
            {
                serviceProvider.AddSingleton(o =>
                {
                    return configurations.ToList();
                });
            }

            serviceProvider.LogoResolve(serviceLifetime);
            serviceProvider.ItemsResolve(serviceLifetime);
        }

        static void LogoResolve(this IServiceCollection serviceProvider, ServiceLifetime serviceLifetime)
        {
            serviceProvider.Add(new ServiceDescriptor(
                typeof(ILogoConnectionConfiguration),
                o =>
                {
                    var firm = o.GetService<List<LogoConnectionConfiguration>>()
                             .FirstOrDefault(f => f.FirmNumber == Thread.CurrentPrincipal.FindFirmNumber()
                                                  && f.FirmPeriod == Thread.CurrentPrincipal.FindFirmPeriod()
                                                  && f.EndpointAddress == Thread.CurrentPrincipal.FindEndpointAddress());

                    if (firm == null)
                        throw new Exception("Firm not found");

                    return firm;
                },
                serviceLifetime));

            serviceProvider.Add(new ServiceDescriptor(typeof(ILogoObjectServiceConfiguration), o => o.GetService<ILogoConnectionConfiguration>(), serviceLifetime));
            serviceProvider.Add(new ServiceDescriptor(typeof(ILogoConfiguration), o => o.GetService<ILogoConnectionConfiguration>(), serviceLifetime));
            serviceProvider.Add(new ServiceDescriptor(typeof(ILogoObjectService), typeof(LogoObjectServiceAdapter), serviceLifetime));
            serviceProvider.Add(new ServiceDescriptor(typeof(ILogoRepository<>), typeof(LogoRepository<>), serviceLifetime));
            serviceProvider.Add(new ServiceDescriptor(typeof(ILogoCrudService<>), typeof(LogoCrudManager<>), serviceLifetime));
        }
        static void ItemsResolve(this IServiceCollection serviceProvider, ServiceLifetime serviceLifetime)
        {
            serviceProvider.Add(new ServiceDescriptor(typeof(IItemDal), typeof(ItemDal), serviceLifetime));
            serviceProvider.Add(new ServiceDescriptor(typeof(IItemService), typeof(ItemManager), serviceLifetime));
        }
    }
}
