using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CLINICAL.Application.UseCase.Extensions
{
    public static class InjectionExtension
    {
        public static IServiceCollection AddInjectionApplication(this IServiceCollection services)
        {
            
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }   
}
