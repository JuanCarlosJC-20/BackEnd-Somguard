using System.Reflection;
using Somnguard.Backend.shared.infrastructure;

namespace Somnguard.Backend.Security.infrastructure.Repository
{
    public class ModuleRepository : BaseRepository<Module>, IModuleRepository
    {
        public ModuleRepository(ApplicationDbContext context) : base(context)
        {
        }
    
    }
}
