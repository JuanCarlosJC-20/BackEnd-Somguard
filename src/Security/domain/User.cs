using Somnguard.Backend.Security.domain;
using Somnguard.Backend.Shared.Domain;

namespace Somnguard.Backend.Security.domain
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }

        // Relación FK
        public Guid PersonId { get; set; }
        public Person Person { get; set; }

        // Relación: Usuario tiene múltiples roles
        public ICollection<RolUser> RolUsers { get; set; } = new List<RolUser>();


        //relaciones que se deben  hacer a futuro para el tema de dispositivos y notificaciones 🚧👌
        
        // Relación: Usuario tiene múltiples asignaciones de dispositivos
       // public ICollection<DeviceAssignment> DeviceAssignments { get; set; } = new List<DeviceAssignment>();
        
        // Relación: Usuario recibe múltiples notificaciones
       // public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    }
    
    
}
