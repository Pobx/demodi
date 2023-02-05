using System;
using DemoDI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI
{
    public static class Startup
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static IServiceProvider Init()
        {
            var serviceProvider = new ServiceCollection()
                .AddSimpleService()
                .AddViewModels()
                .AddPostApiService()
                .BuildServiceProvider();

            ServiceProvider = serviceProvider;

            return serviceProvider;
        }
    }
}

