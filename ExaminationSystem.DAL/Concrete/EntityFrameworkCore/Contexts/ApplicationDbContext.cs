using ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping.ExtensionMethods;
using ExaminationSystem.Entities.Concrete;

using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TypeBuilderExtensionMethods).Assembly);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<UserQuestion> UserQuestions { get; set; }
    public DbSet<Topic> Topics { get; set; }
}
