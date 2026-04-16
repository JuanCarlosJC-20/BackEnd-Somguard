using Somnguard.Backend.Security.domain;
using Somnguard.Backend.shared.infrastructure;
namespace Somnguard.Backend.Security.infrastructure.Repository


{
   public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
