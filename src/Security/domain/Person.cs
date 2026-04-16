using Somnguard.Backend.Security.domain;
using Somnguard.Backend.Shared.Domain;

namespace Somnguard.Backend.Security.domain;

public class Person : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }

    // Relación: Una persona tiene múltiples usuarios
    public ICollection<User> Users { get; set; } = new List<User>();
}