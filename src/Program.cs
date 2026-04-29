using Somnguard.Backend.Security.application.Mappings;
using Somnguard.Backend.Security.application.Services;
using Somnguard.Backend.Security.infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Registrar Security Infrastructure (DbContext + Repositories)
builder.Services.AddSecurityInfrastructure(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(SecurityMappingProfile).Assembly);
builder.Services.AddScoped<IUserService, UserService>();

// Configurar Swagger
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Somnguard API v1");
        options.RoutePrefix = string.Empty; // Swagger en la raíz (/)
    });
}

app.MapGet("/", () => Results.Ok(new
{
    service = "somnguard-backend",
    status = "running"
}));

app.MapGet("/health", () => Results.Ok(new
{
    status = "healthy"
}));

app.MapControllers();

app.Run();