namespace Somnguard.Backend.Security.application.Dto.RequesDto
{
    public class RoleFormPermissionRequestDto
    {
        public Guid RoleId { get; set; }
        public Guid FormId { get; set; }
        public Guid PermissionId { get; set; }
    }
}
