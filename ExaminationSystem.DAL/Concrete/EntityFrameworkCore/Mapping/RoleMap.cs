using ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping.ExtensionMethods;
using ExaminationSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping;

public class RoleMap : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.EntityBaseMap();
        builder.Property(x=>x.Name).IsRequired();
    }
}
