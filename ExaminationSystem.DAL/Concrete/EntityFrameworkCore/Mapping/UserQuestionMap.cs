using ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping.ExtensionMethods;
using ExaminationSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping;

public class UserQuestionMap : IEntityTypeConfiguration<UserQuestion>
{
    public void Configure(EntityTypeBuilder<UserQuestion> builder)
    {
        builder.EntityBaseMap();

        builder.Property(x=>x.StepOneDate).IsRequired(false);
        builder.Property(x=>x.StepTwoDate).IsRequired(false);
        builder.Property(x=>x.StepThreeDate).IsRequired(false);
        builder.Property(x=>x.StepFourDate).IsRequired(false);
        builder.Property(x=>x.StepFiveDate).IsRequired(false);
        builder.Property(x=>x.StepSixDate).IsRequired(false);

        builder.Property(x=>x.QuestionLevel).IsRequired();

        builder.HasOne(x=>x.User)
            .WithMany(x=>x.UserQuestions)
            .HasForeignKey(x=>x.UserId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
