﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using Ies.Logo.Core.Configuration;
using Ies.Logo.Repositories;
using Ies.Logo.ServiceAdapter;
using Ies.MultiFirm.ClCards;
using Ies.MultiFirm.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ies.MultiFirm.DepedencyResolvers.Microsoft
{
    public static class Resolver
    {
        public static void Resolve(this IServiceCollection serviceProvider)
        {
            ResolveLogo(serviceProvider);

            serviceProvider
                .AddScoped<IClCardDal, ClCardDal>()
                .AddScoped<IClCardService, ClCardManager>()
                ;
        }
        static void ResolveLogo(IServiceCollection serviceProvider)
        {
            serviceProvider.AddSingleton(o =>
            {
                var configuration = o.GetService<IConfiguration>();
                var firms = new List<Firm>();
                configuration.Bind("Firms", firms);
                return firms;
            });

            serviceProvider
                .AddScoped<ILogoExtendedConfiguration, LogoExtendedConfiguration>(o =>
                {
                    var firm = o.GetService<List<Firm>>().FirstOrDefault(f => f.FirmNumber == Thread.CurrentPrincipal.FindFirmNumber()
                                                                              && f.FirmPeriod == Thread.CurrentPrincipal.FindFirmPeriod()
                                                                              && f.EndpointAddress == Thread.CurrentPrincipal.FindEndpointAddress()
                                                                         );
                    if (firm == null)
                        throw new Exception("Firma bulunamadı");

                    var configuration = new LogoExtendedConfiguration(firm.ConnectionString)
                    {
                        FirmNumber = firm.FirmNumber,
                        FirmPeriod = firm.FirmPeriod,
                        OldFirmNumber = firm.OldFirmNumber,
                        OldFirmPeriod = firm.OldFirmPeriod,
                        SecurityCode = firm.SecurityCode,
                        EndpointAddress = firm.EndpointAddress,
                        Lbsloadpass = firm.Lbsloadpass,
                        UseCompressedString = firm.UseCompressedString
                    };
                    
                    return configuration;
                })
                .AddScoped<ILogoConnectionConfiguration, ILogoExtendedConfiguration>(o => o.GetService<ILogoExtendedConfiguration>())
                .AddScoped<ILogoObjectServiceConfiguration, ILogoExtendedConfiguration>(o => o.GetService<ILogoExtendedConfiguration>())
                .AddScoped<ILogoConfiguration, ILogoExtendedConfiguration>(o => o.GetService<ILogoExtendedConfiguration>())
                .AddScoped<ILogoObjectService, LogoObjectServiceAdapter>()
                .AddScoped(typeof(ILogoRepository<>), typeof(LogoRepository<>));
        }
    }
}