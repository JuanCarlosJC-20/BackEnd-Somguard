using Somnguard.Backend.shared.application;

namespace Somnguard.Backend.Security.application.ResponseDto
{
    public class RoleResponseDto : BaseEntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
