using BurcusBlog.Data.Context;
using BurcusBlog.Data.Repositories.Abstractions;
using BurcusBlog.Data.Repositories.Concretes;
using BurcusBlog.Data.UnitOfWorks;
using BurcusBlog.Service.Services.Abstractions;
using BurcusBlog.Service.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace BurcusBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceExtensions(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
