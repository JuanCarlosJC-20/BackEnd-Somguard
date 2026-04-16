using Microsoft.EntityFrameworkCore;
using Somnguard.Backend.Security.domain;


namespace Somnguard.Backend.Security.infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        // Tablas
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolUser> RolUsers { get; set; }
        public DbSet<RoleFormPermission> RoleFormPermissions { get; set; }
        public DbSet<FormModule> FormModules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User -> Person (1:N)
            modelBuilder.Entity<User>()
                .HasOne(u => u.Person)
                .WithMany(p => p.Users)
                .HasForeignKey(u => u.PersonId);

            // Role -> RolUser (1:N)
            modelBuilder.Entity<Role>()
                .HasMany(r => r.RolUsers)
                .WithOne(ru => ru.Role)
                .HasForeignKey(ru => ru.RoleId);

            // User -> RolUser (1:N)
            modelBuilder.Entity<User>()
                .HasMany(u => u.RolUsers)
                .WithOne(ru => ru.User)
                .HasForeignKey(ru => ru.UserId);

            // Role -> RoleFormPermission (1:N)
            modelBuilder.Entity<Role>()
                .HasMany(r => r.RoleFormPermissions)
                .WithOne(rfp => rfp.Role)
                .HasForeignKey(rfp => rfp.RoleId);

            // Form -> RoleFormPermission (1:N)
            modelBuilder.Entity<Form>()
                .HasMany(f => f.RoleFormPermissions)
                .WithOne(rfp => rfp.Form)
                .HasForeignKey(rfp => rfp.FormId);

            // Permission -> RoleFormPermission (1:N)
            modelBuilder.Entity<Permission>()
                .HasMany(p => p.RoleFormPermissions)
                .WithOne(rfp => rfp.Permission)
                .HasForeignKey(rfp => rfp.PermissionId);

            // Module -> FormModule (1:N)
            modelBuilder.Entity<Module>()
                .HasMany(m => m.FormModules)
                .WithOne(fm => fm.Module)
                .HasForeignKey(fm => fm.ModuleId);

            // Form -> FormModule (1:N)
            modelBuilder.Entity<Form>()
                .HasMany(f => f.FormModules)
                .WithOne(fm => fm.Form)
                .HasForeignKey(fm => fm.FormId);
        }
    }
}