using Somnguard.Backend.Security.application.Dto.RequesDto;
using Somnguard.Backend.Security.application.Dto.ResponseDto;

namespace Somnguard.Backend.Security.application.Services
{
    public interface IUserService
    {
        Task<UserResponseDto> GetByIdAsync(Guid id);
        Task<IEnumerable<UserResponseDto>> GetAllAsync();
        Task<UserResponseDto> CreateAsync(UserRequestDto dto);
        Task<UserResponseDto> UpdateAsync(Guid id, UserRequestDto dto);
        Task DeleteAsync(Guid id);
    }
}