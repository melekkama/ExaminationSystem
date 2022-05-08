using ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping.ExtensionMethods;
using ExaminationSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping;

public class TopicMap : IEntityTypeConfiguration<Topic>
{
    public void Configure(EntityTypeBuilder<Topic> builder)
    {
        builder.EntityBaseMap();
        builder.Property(x=>x.Name).IsRequired();
    }
}
