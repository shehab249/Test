namespace TEST.Services.Abstractions;

public interface IProjectService
{
    public Task<bool> DeleteProjectByIdAync(int projectId, CancellationToken token = default);
}