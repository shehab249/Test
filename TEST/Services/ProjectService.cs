using TEST.Repositories.Abstractions;
using TEST.Services.Abstractions;

namespace TEST.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }


    public async Task<bool> DeleteProjectByIdAync(int projectId, CancellationToken token = default)
    => await _projectRepository.DeleteProjectByIdAync(projectId, token);
    
    
}