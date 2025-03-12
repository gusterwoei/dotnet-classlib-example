using DotnetLibExample.Lib.Api;
using DotnetLibExample.Lib.Services;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace DotnetLibExample.Lib
{
    public static class MyConfigExtensions
    {
        public static IServiceCollection AddMyDogService(this IServiceCollection services)
        {
            services.AddRefitClient<IDogApi>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://dog.ceo"));
            services.AddSingleton<DogService>();

            return services;
        }
    }
}