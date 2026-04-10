using Somnguard.Backend.Shared.Domain;

namespace Somnguard.Backend.Security.domain
{
    public class RolUser : BaseEntity
    {
        // Claves foráneas
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        // Propiedades de navegación
        public User User { get; set; } = null!;
        public Role Role { get; set; } = null!;
    }
}
