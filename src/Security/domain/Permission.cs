using Somnguard.Backend.Shared.Domain;

namespace Somnguard.Backend.Security.domain
{
    public class Permission : BaseEntity
    {
        public string Name { get; set; }

        // Relación: Un permiso está asociado a múltiples roles en formularios
        public ICollection<RoleFormPermission> RoleFormPermissions { get; set; } = new List<RoleFormPermission>();
    }
}
