using Finbuckle.MultiTenant.Abstractions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using FSH.Framework.Infrastructure.Tenant;
using LearningManagementSystem.ApiService.Features.Content.Data;
using LearningManagementSystem.Shared.Contants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LearningManagementSystem.ApiService.Infrastructure.EfCore;

public sealed class ApplicationDbContext : FshDbContext
{
    public ApplicationDbContext(IMultiTenantContextAccessor<FshTenantInfo> multiTenantContextAccessor, 
        DbContextOptions<ApplicationDbContext> options, IPublisher publisher, IOptions<DatabaseOptions> settings)
        : base(multiTenantContextAccessor, options, publisher, settings)
    {
    }
    
    public DbSet<Activity> Activities => Set<Activity>();
    public DbSet<ActivityMilestoneRequirements> MilestoneRequirementTypes => Set<ActivityMilestoneRequirements>();
    public DbSet<ActivityQuizOptions> ActivityQuizOptions => Set<ActivityQuizOptions>();
    public DbSet<ActivityVideoOptions> ActivityVideoOptions => Set<ActivityVideoOptions>();

    public DbSet<Course> Courses => Set<Course>();
    public DbSet<LearningPath> LearningPaths => Set<LearningPath>();
    public DbSet<LearningPathCourse> LearningPathCourses => Set<LearningPathCourse>();
    public DbSet<Media> Medias => Set<Media>();
    public DbSet<Quiz> Quizzes => Set<Quiz>();
    public DbSet<QuizQuestion> QuizQuestions => Set<QuizQuestion>();
    public DbSet<QuizOption> QuizOptions => Set<QuizOption>();
    public DbSet<Section> Sections => Set<Section>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ArgumentNullException.ThrowIfNull(modelBuilder);
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);
        modelBuilder.HasDefaultSchema(SchemaNames.Catalog);
    }

}