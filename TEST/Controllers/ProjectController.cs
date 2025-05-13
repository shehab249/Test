using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TEST.Repositories.Abstractions;
using TEST.Services.Abstractions;

namespace TEST.Controllers;

[ApiController]
[Route("api/tasks")]
public class ProjectController : ControllerBase
{
    private readonly IProjectService _projectService;

    public ProjectController(IProjectService projectService)
    {
        _projectService = projectService;
        
    }

    [HttpDelete("{projectId:int}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> DeleteProjectByIdAsync(int projectId, CancellationToken token = default)
    {
        var deleted = await _projectService.DeleteProjectByIdAync(projectId, token);
        if(!deleted)
            return NotFound($"Project with ID {projectId} not found");

        return NoContent();
    }
}