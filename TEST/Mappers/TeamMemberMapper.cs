using TEST.Contracts.Responses;
using TEST.Entities;
using Task = TEST.Entities.Task;

namespace TEST.Mappers;

public static class TeamMemberMapper
{
    public static GetAllTeamMembersWithTasksResponse MapToGetAllTeamMembersWithTasksResponse(this Task task)
    {
        return new GetAllTeamMembersWithTasksResponse
        {
            IdTeamMember = task.TeamMember.IdTeamMember,
            FirstName = task.TeamMember.FirstName,
            LastName = task.TeamMember.LastName,
            Email = task.TeamMember.Email,
            AssignedToHim = new MemberTasksAssignedToHimResponse()
            {
                IdTask = task.IdTask,
                Name = task.Name,
                Description = task.Description,
                Deadline = task.Deadline,
                IdProject = task.IdProject,
                IdTaskType = task.IdTaskType
            },
            CreatedByTeamMember = new MemberTasksCreatedByTeamMemberResponse()
            {
                IdTask = task.IdTask,
                Name = task.Name,
                Description = task.Description,
                Deadline = task.Deadline,
                IdProject = task.IdProject,
                IdTaskType = task.IdTaskType
            }
        };
    }
}