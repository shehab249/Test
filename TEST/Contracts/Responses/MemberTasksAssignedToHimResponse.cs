namespace TEST.Contracts.Responses;

public record struct MemberTasksAssignedToHimResponse
(
  int IdTask,
  string Name,
  string Description,
  DateTime Deadline,
  int IdProject,
  int IdTaskType
);
    

