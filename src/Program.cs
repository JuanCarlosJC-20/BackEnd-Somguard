using Somnguard.Backend.Security.application.Mappings;
using Somnguard.Backend.Security.application.Services;
using Somnguard.Backend.Security.infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Registrar Security Infrastructure (DbContext + Repositories)
builder.Services.AddSecurityInfrastructure(builder.Configuration);


builder.Services.AddAutoMapper(typeof(SecurityMappingProfile).Assembly);
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new
{
    service = "somnguard-backend",
    status = "running"
}));

app.MapGet("/health", () => Results.Ok(new
{
    status = "healthy"
}));

app.Run();