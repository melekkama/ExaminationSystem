using ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping.ExtensionMethods;
using ExaminationSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping;

public class QuestionMap : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.EntityBaseMap();
        builder.Property(prop => prop.ImageName).IsRequired(false);
        builder.Property(prop => prop.Content).IsRequired();
        builder.Property(prop => prop.ChooseA).IsRequired();
        builder.Property(prop => prop.ChooseB).IsRequired();
        builder.Property(prop => prop.ChooseC).IsRequired();
        builder.Property(prop => prop.ChooseD).IsRequired();
        builder.Property(prop => prop.Answer).IsRequired();
        builder.Property(prop => prop.IsActive).IsRequired();

        builder.HasMany(x => x.UserQuestions)
            .WithOne(x => x.Question)
            .HasForeignKey(x => x.QuestionId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Topic)
            .WithMany(x => x.Questions)
            .HasForeignKey(x => x.TopicId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
