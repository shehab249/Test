using Microsoft.Data.SqlClient;
using TEST.Repositories.Abstractions;

namespace TEST.Repositories;

public class ProjectRepository : IProjectRepository
{
    
    private readonly string _connectionString;

    public ProjectRepository(IConfiguration cfg)
    {
        _connectionString = cfg.GetConnectionString("Default") ??
                            throw new ArgumentNullException(nameof(cfg),
                                "Default connection string is missing in configuration");
    }

    public async Task<bool> DeleteProjectByIdAync(int projectId, CancellationToken token = default)
    {
        await using var con = new SqlConnection(_connectionString);
        await con.OpenAsync();

        SqlTransaction transaction = con.BeginTransaction();

        try
        {
            using var deletetasksCommand =
                new SqlCommand("DELETE FROM Task WHERE IdProject = @projectId", con, transaction);
            deletetasksCommand.Parameters.AddWithValue("@projectId", projectId);
            await deletetasksCommand.ExecuteNonQueryAsync(token);

            using var deleteProjectCommand =
                new SqlCommand("DELETE FROM [Project] WHERE IdProject = @projectId", con, transaction);
            deleteProjectCommand.Parameters.AddWithValue("@projectId", projectId);

            int affectedRows = await deleteProjectCommand.ExecuteNonQueryAsync(token);

            if (affectedRows == 0)
            {
                await transaction.RollbackAsync(token);
                return false;
            }

            await transaction.CommitAsync(token);
            return true;
               
        } catch
        {
            await transaction.RollbackAsync(token);
            throw;
        }
    }

    
}