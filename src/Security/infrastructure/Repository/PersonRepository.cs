using Somnguard.Backend.Security.domain;
using Somnguard.Backend.shared.infrastructure;

namespace Somnguard.Backend.Security.infrastructure.Repository
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
    
}
