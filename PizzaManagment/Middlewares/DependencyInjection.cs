using Application.Interfaces;
using Infrastructure.Services;

namespace PizzaManagment.Middlewares;

public static class DependencyInjection 
{
    public static void InitializeServices(this IServiceCollection services)
    {
     services.AddScoped<ExceptionMiddleware>();   
     services.AddScoped<ITokenService, TokenService>();
    }
    
}