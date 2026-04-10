using Somnguard.Backend.shared.application;

namespace Somnguard.Backend.Security.application.ResponseDto
{
    public class FormModuleResponseDto : BaseEntityDto
    {
        public Guid ModuleId { get; set; }
        public Guid FormId { get; set; }
    }
}
