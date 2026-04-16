namespace Somnguard.Backend.Security.application.Dto.RequesDto
{
    public class UserRequestDto
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public Guid PersonId { get; set; }
    }
}
