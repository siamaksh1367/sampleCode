using I18NPortable;
using Microsoft.Extensions.DependencyInjection;
using proj.components.Components;
using proj.components.Helper;
using proj.components.Services.Local;
using proj.models;
using System.Reflection;

namespace proj.service.registrations
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {

            services.AddTransient<ILocalService<NavItemData, NavItems>, NavItemsService>();
            services.AddTransient<ILocalService<LanguageData, Languages>, LanguageService>();
            services.AddSingleton((_) =>
                I18N.Current
                .SetNotFoundSymbol("$")
                .SetFallbackLocale("en-US")
                .Init(Assembly.GetAssembly(typeof(proj.components.Components.Languages)))
                );
            services.AddSingleton(new LanguageChangeEvents());
            //services.AddScoped<IUserSerivce, UserService>();
            //services.AddScoped<IItemListAbstractFactory<string, Authorized>, AuthorizedListFactory>();
            //services.AddScoped<IItemListAbstractFactory<string, TestListFactory>, TestListFactory>();
            //services.AddScoped<IItemListAbstractFactory<string, UnAuthorized>, UnAuthorizedListFactory>();
            //services.AddScoped<IItemListAbstractFactory<string, Languages>, LanguagesListFactory>();
            //services.AddScoped<IItemListAbstractFactory<string, NavItems>, NavItemsListFactory>();
            return services;
        }
    }
}