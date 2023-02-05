using System;
using DemoDI.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI.Services
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddSimpleService(this IServiceCollection services)
        {
            services.AddTransient<IHelloService, HelloService>();

            return services;
        }

        public static IServiceCollection AddViewModels(this IServiceCollection services)
        {
            services.AddTransient<PostViewModel>();

            return services;
        }

        public static IServiceCollection AddPostApiService(this IServiceCollection services)
        {
            services.AddHttpClient<PostService>()
               .ConfigureHttpClient(c =>
               {
                   c.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
                   c.Timeout = TimeSpan.FromMinutes(10);
               });

            return services;
        }
    }
}

