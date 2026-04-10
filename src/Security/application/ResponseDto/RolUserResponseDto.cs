using Somnguard.Backend.shared.application;

namespace Somnguard.Backend.Security.application.ResponseDto
{
    public class RolUserResponseDto : BaseEntityDto
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}
