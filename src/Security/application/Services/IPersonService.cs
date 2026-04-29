using Somnguard.Backend.Security.application.Dto.RequesDto;
using Somnguard.Backend.Security.application.Dto.ResponseDto;

namespace Somnguard.Backend.Security.application.Services
{
    public interface IPersonService
    {
        Task<PersonResponseDto> GetByIdAsync(Guid id);
        Task<IEnumerable<PersonResponseDto>> GetAllAsync();
        Task<PersonResponseDto> CreateAsync(PersonRequestDto dto);
        Task<PersonResponseDto> UpdateAsync(Guid id, PersonRequestDto dto);
        Task DeleteAsync(Guid id);
    }
}

