using Somnguard.Backend.Shared.Domain;

namespace Somnguard.Backend.Security.domain
{
    public class Module : BaseEntity
    {
        public string Name { get; set; }

        // Relación: Un módulo contiene múltiples formularios
        public ICollection<FormModule> FormModules { get; set; } = new List<FormModule>();
    }
}
