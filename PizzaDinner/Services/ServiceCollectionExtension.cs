using Microsoft.Extensions.DependencyInjection;
using PizzaDinner.Models;
using PizzaDinner.ViewModels;
using PizzaDinner.Views;

namespace PizzaDinner.Services;

public static class ServiceCollectionExtension
{
    public static void AddCommonServices(this IServiceCollection collection)
    {
        collection.AddSingleton<MainViewModel>();
        collection.AddTransient<MainWindow>();
        
        collection.AddSingleton<IProductFactory, ProductFactory>();
    }   
}