using AutoMapper;
using Somnguard.Backend.Security.application.Dto.RequesDto;
using Somnguard.Backend.Security.application.Dto.ResponseDto;
using Somnguard.Backend.Security.infrastructure.Repository;

namespace Somnguard.Backend.Security.application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserResponseDto> GetByIdAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserResponseDto>(user);
        }

        public async Task<IEnumerable<UserResponseDto>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(u => _mapper.Map<UserResponseDto>(u));
        }

        public async Task<UserResponseDto> CreateAsync(UserRequestDto dto)
        {
            var user = _mapper.Map<Somnguard.Backend.Security.domain.User>(dto);

            // Importante: aquí luego deberías hashear el password (no guardarlo plano).
            var created = await _userRepository.CreateAsync(user);

            return _mapper.Map<UserResponseDto>(created);
        }

        public async Task<UserResponseDto> UpdateAsync(Guid id, UserRequestDto dto)
        {
            var existing = await _userRepository.GetByIdAsync(id);

            existing.Email = dto.Email;
            existing.Password = dto.Password; // luego: hash
            existing.PersonId = dto.PersonId;

            await _userRepository.SaveChangesAsync();

            return _mapper.Map<UserResponseDto>(existing);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _userRepository.DeleteAsync(id);
        }
    }
}