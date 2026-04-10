using Somnguard.Backend.Shared.Domain;

namespace Somnguard.Backend.Security.domain
{
    public class FormModule : BaseEntity
    {
        // Claves foráneas
        public Guid ModuleId { get; set; }
        public Guid FormId { get; set; }

        // Propiedades de navegación
        public Module Module { get; set; } = null!;
        public Form Form { get; set; } = null!;
    }
}
