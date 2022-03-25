using ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping.ExtensionMethods;
using ExaminationSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.EntityBaseMap();
        builder.Property(x=>x.FirstName).IsRequired();
        builder.Property(x=>x.LastName).IsRequired();
        builder.Property(x=>x.Email).IsRequired();
        builder.Property(x=>x.Passowrd).IsRequired();
    }
}
