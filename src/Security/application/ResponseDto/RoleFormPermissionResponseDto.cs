using Somnguard.Backend.shared.application;

namespace Somnguard.Backend.Security.application.ResponseDto
{
    public class RoleFormPermissionResponseDto : BaseEntityDto
    {
        public Guid RoleId { get; set; }
        public Guid FormId { get; set; }
        public Guid PermissionId { get; set; }
    }
}
