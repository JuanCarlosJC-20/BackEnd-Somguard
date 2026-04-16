using Somnguard.Backend.Security.domain;
using Somnguard.Backend.shared.infrastructure;

namespace Somnguard.Backend.Security.infrastructure.Repository
{
    public class PermissionRepository : BaseRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
    
}
