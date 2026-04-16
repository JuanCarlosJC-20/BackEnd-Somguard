using Somnguard.Backend.shared.application;

namespace Somnguard.Backend.Security.application.Dto.ResponseDto
{
    public class PersonResponseDto : BaseEntityDto
    {
      public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Phone { get; set; }
    }
}
