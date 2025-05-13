namespace TEST.Contracts.Responses;

public record struct MemberTasksCreatedByTeamMemberResponse
(
    int IdTask,
    string Name,
    string Description,
    DateTime Deadline,
    int IdProject,
    int IdTaskType
    );