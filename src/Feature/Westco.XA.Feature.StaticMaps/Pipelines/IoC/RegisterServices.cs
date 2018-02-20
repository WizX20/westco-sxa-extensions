﻿using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Westco.XA.Feature.StaticMaps.Repositories;

namespace Westco.XA.Feature.StaticMaps.Pipelines.IoC
{
    internal class RegisterServices : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IStaticMapRepository, StaticMapsRepository>();
        }
    }
}