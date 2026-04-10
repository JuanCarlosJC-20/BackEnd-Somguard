using Somnguard.Backend.Shared.Domain;

namespace Somnguard.Backend.Security.domain
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // Relación: Un rol tiene múltiples usuarios asignados
        public ICollection<RolUser> RolUsers { get; set; } = new List<RolUser>();
        
        // Relación: Un rol tiene múltiples permisos en formularios
        public ICollection<RoleFormPermission> RoleFormPermissions { get; set; } = new List<RoleFormPermission>();
    }
}
