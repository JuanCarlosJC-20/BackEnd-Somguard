using Somnguard.Backend.Shared.Domain;

namespace Somnguard.Backend.Security.domain
{
    public class RoleFormPermission : BaseEntity
    {
        // Claves foráneas
        public Guid RoleId { get; set; }
        public Guid FormId { get; set; }
        public Guid PermissionId { get; set; }

        // Propiedades de navegación
        public Role Role { get; set; } = null!;
        public Form Form { get; set; } = null!;
        public Permission Permission { get; set; } = null!;
    }
}
