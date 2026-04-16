using AutoMapper;
using Somnguard.Backend.Security.application.Dto.RequesDto;
using Somnguard.Backend.Security.application.Dto.ResponseDto;
using Somnguard.Backend.Security.domain;

namespace Somnguard.Backend.Security.application.Mappings
{
    public class SecurityMappingProfile : Profile
    {
        public SecurityMappingProfile()
        {
            CreateMap<User, UserResponseDto>();
            CreateMap<UserRequestDto, User>();
        }
    }
}