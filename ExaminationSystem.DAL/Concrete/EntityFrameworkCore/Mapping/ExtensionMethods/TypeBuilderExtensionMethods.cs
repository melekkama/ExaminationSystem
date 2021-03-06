using ExaminationSystem.DAL.StringInfos;
using ExaminationSystem.Entities.Interfaces;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationSystem.DAL.Concrete.EntityFrameworkCore.Mapping.ExtensionMethods;

public static class TypeBuilderExtensionMethods
{
    public static void EntityBaseMap<TEntity>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : class, IEntityBase, new()
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasDefaultValueSql("newid()").ValueGeneratedOnAdd();
        builder.Property(x => x.CreatedTime).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd().IsRequired();
        builder.Property(x => x.UpdatedTime).IsRequired(false);
        builder.Property(x => x.CreatedUserId).IsRequired().HasDefaultValue(new Guid(SystemUserInfo.SystemUserId)); ;
        builder.Property(x => x.UpdatedUserId).IsRequired(false);
        builder.Property(x => x.IsDeleted).HasDefaultValue(false).IsRequired();

    }
}