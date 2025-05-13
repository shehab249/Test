using TEST.Repositories.Abstractions;

namespace TEST.Repositories.Extensions;

public static class ServicesCollectionsExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IProjectRepository, ProjectRepository>();

        return services;
    }
}