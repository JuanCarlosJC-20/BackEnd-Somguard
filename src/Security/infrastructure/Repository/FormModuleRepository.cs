using Somnguard.Backend.Security.domain;
using Somnguard.Backend.shared.infrastructure;

namespace Somnguard.Backend.Security.infrastructure.Repository
{
    public class FormModuleRepository : BaseRepository<FormModule>, IFormModuleRepository
    {
        public FormModuleRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
