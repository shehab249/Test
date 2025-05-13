using TEST.Services.Abstractions;

namespace TEST.Services.Extensions;

public static class ServicesCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IProjectService, ProjectService>();
        return services;
    }
}