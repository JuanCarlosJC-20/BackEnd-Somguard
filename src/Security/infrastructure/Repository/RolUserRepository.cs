using Somnguard.Backend.Security.domain;
using Somnguard.Backend.shared.infrastructure;

namespace Somnguard.Backend.Security.infrastructure.Repository
{
    public class RolUserRepository : BaseRepository<RolUser>, IRolUserRepository
    {
        public RolUserRepository(ApplicationDbContext context) : base(context)
        {
        }
    
    }
}
