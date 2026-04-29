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
            //user
            CreateMap<User, UserResponseDto>();
            CreateMap<UserRequestDto, User>();
            //person
            CreateMap<Person, PersonResponseDto>();
            CreateMap<PersonRequestDto, Person>();
            //Rol
            CreateMap<Role, RoleResponseDto>();
            CreateMap<RoleRequestDto, Role>();
            //RolUser
            CreateMap<RolUser, RolUserResponseDto>();
            CreateMap<RolUserRequestDto, RolUser>();
            //RoleFormPermission
            CreateMap<RoleFormPermission, RoleFormPermissionResponseDto>();
            CreateMap<RoleFormPermissionRequestDto, RoleFormPermission>();
            //Permission
            CreateMap<Permission, PermissionResponseDto>();
            CreateMap<PermissionRequestDto, Permission>();
            //Module
            CreateMap<Module, ModuleResponseDto>();
            CreateMap<ModuleRequestDto, Module>();
            //Form
            CreateMap<Form, FormResponseDto>();
            CreateMap<FormRequestDto, Form>();
            //FormModule
            CreateMap<FormModule, FormModuleResponseDto>();
            CreateMap<FormModuleRequestDto, FormModule>();
        }
    }
}

