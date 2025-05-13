namespace TEST.Contracts.Responses;

public record struct GetAllTeamMembersWithTasksResponse
(
    int IdTeamMember,
    string FirstName,
    string LastName,
    string Email,
    MemberTasksAssignedToHimResponse AssignedToHim,
    MemberTasksCreatedByTeamMemberResponse CreatedByTeamMember
);