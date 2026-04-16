using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Somnguard.Backend.Security.infrastructure.Repository;

namespace Somnguard.Backend.Security.infrastructure.DependencyInjection
{
    public static class SecurityInfrastructure
    {
        public static IServiceCollection AddSecurityInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IModuleRepository, ModuleRepository>();
            services.AddScoped<IFormRepository, FormRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IRolUserRepository, RolUserRepository>();
            services.AddScoped<IRoleFormPermissionRepository, RoleFormPermissionRepository>();
            services.AddScoped<IFormModuleRepository, FormModuleRepository>();

            return services;
        }
    }
}