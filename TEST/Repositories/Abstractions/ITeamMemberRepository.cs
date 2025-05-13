using TEST.Entities;

namespace TEST.Repositories.Abstractions;

public interface ITeamMemberRepository
{
    public Task<ICollection<TeamMember?>> GetTeamMembers(int memberId,CancellationToken token = default);
    
}