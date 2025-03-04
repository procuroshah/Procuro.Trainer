using LearningManagementSystem.ApiService.Features.Content.Data;
using LearningManagementSystem.Shared.Contants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningManagementSystem.ApiService.Features.Content.Infrastructure;

//public class CoursesEntityConfiguration : IEntityTypeConfiguration<Course>
//{
//    public void Configure(EntityTypeBuilder<Course> builder)
//    {
//        builder.ToTable("courses", SchemaNames.Catalog);
//    }
//}
//public class SectionsEntityConfiguration : IEntityTypeConfiguration<Section>
//{
//    public void Configure(EntityTypeBuilder<Section> builder)
//    {
//        builder.ToTable("course_sections", SchemaNames.Catalog);
//    }
//}
//public class ActivitysEntityConfiguration : IEntityTypeConfiguration<Activity>
//{
//    public void Configure(EntityTypeBuilder<Activity> builder)
//    {
//        builder.ToTable("section_activities", SchemaNames.Catalog);
//    }
//}

public class MilestoneRequirementTypeConfiguration : IEntityTypeConfiguration<ActivityMilestoneRequirements>
{
    public void Configure(EntityTypeBuilder<ActivityMilestoneRequirements> builder)
    {
        builder.OwnsMany(x => x.MilestoneProps);
    }
}