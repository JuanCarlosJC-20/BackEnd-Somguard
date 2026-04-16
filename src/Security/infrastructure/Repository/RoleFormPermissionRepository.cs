using Somnguard.Backend.Security.domain;
using Somnguard.Backend.shared.infrastructure;

namespace Somnguard.Backend.Security.infrastructure.Repository
{
    public class RoleFormPermissionRepository : BaseRepository<RoleFormPermission>, IRoleFormPermissionRepository
    {
        public RoleFormPermissionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
    
}
