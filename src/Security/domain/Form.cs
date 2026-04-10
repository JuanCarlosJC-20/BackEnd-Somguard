using Somnguard.Backend.Shared.Domain;

namespace Somnguard.Backend.Security.domain
{
    public class Form : BaseEntity
    {
        public string Name { get; set; }

        // Relación: Un formulario está asociado a múltiples módulos
        public ICollection<FormModule> FormModules { get; set; } = new List<FormModule>();
        
        // Relación: Un formulario tiene múltiples permisos de rol
        public ICollection<RoleFormPermission> RoleFormPermissions { get; set; } = new List<RoleFormPermission>();
    }
}
