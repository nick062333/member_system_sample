using MemberSystem.Application.DTOs;

namespace MemberSystem.Application.Queries
{
    public interface IOrgService 
    {
        public Task<IEnumerable<OrgDTO>> GetAllOrgListAsync();
    }
}
