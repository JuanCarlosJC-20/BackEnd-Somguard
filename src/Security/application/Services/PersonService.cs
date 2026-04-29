using AutoMapper;
using Somnguard.Backend.Security.application.Dto.RequesDto;
using Somnguard.Backend.Security.application.Dto.ResponseDto;
using Somnguard.Backend.Security.domain;
using Somnguard.Backend.Security.infrastructure.Repository;

namespace Somnguard.Backend.Security.application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<PersonResponseDto> GetByIdAsync(Guid id)
        {
            var person = await _personRepository.GetByIdAsync(id);
            return _mapper.Map<PersonResponseDto>(person);
        }

        public async Task<IEnumerable<PersonResponseDto>> GetAllAsync()
        {
            var person = await _personRepository.GetAllAsync();
            return person.Select(p => _mapper.Map<PersonResponseDto>(p));
        }

        public async Task<PersonResponseDto> CreateAsync(PersonRequestDto dto)
        {
            var person = _mapper.Map<Person>(dto);
            var Created = await _personRepository.CreateAsync(person);
            return _mapper.Map<PersonResponseDto>(Created);
        }
        public async Task<PersonResponseDto> UpdateAsync(Guid id, PersonRequestDto dto)
        {
            var existing = await _personRepository.GetByIdAsync(id);
            existing.Phone = dto.Phone;
            existing.FirstName = dto.FirstName;
            existing.LastName = dto.LastName;
            await _personRepository.SaveChangesAsync();
            return _mapper.Map<PersonResponseDto>(existing);

        }

        public async Task DeleteAsync(Guid id)
        {
            await _personRepository.DeleteAsync(id);
        }
    }
}

