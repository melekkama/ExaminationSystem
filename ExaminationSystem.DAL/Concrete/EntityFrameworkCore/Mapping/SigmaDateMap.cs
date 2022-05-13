using ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping.ExtensionMethods;
using ExaminationSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping;

public class SigmaDateMap : IEntityTypeConfiguration<SigmaDate>
{
    public void Configure(EntityTypeBuilder<SigmaDate> builder)
    {
        builder.EntityBaseMap();
        builder.Property(x => x.StepOneDate).IsRequired();
        builder.Property(x => x.StepTwoDate).IsRequired();
        builder.Property(x => x.StepThreeDate).IsRequired();
        builder.Property(x => x.StepFourDate).IsRequired();
        builder.Property(x => x.StepFiveDate).IsRequired();
        builder.Property(x => x.StepSixDate).IsRequired();
    }
}
