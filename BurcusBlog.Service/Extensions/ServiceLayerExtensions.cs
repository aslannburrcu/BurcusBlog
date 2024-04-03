using BurcusBlog.Data.Context;
using BurcusBlog.Data.Repositories.Abstractions;
using BurcusBlog.Data.Repositories.Concretes;
using BurcusBlog.Data.UnitOfWorks;
using BurcusBlog.Service.Services.Abstractions;
using BurcusBlog.Service.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace BurcusBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceExtensions(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService, ArticleService>();

            services.AddAutoMapper(assembly);
            return services;
        }
    }
}
