namespace TEST.Repositories.Abstractions;

public interface IProjectRepository
{
    public Task<bool> DeleteProjectByIdAync(int projectId, CancellationToken token = default);
}