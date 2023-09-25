using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MemberSystem.Domain.AggregatesModel.UserAggregate;

namespace MemberSystem.Infrastructure.EntityFrameworkCore.EntityTypeConfiguration
{
    class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.HasKey(b => b.Id).HasName("id");
            builder.Property(b => b.OrgId).HasColumnName("org_id");
            builder.Property(b => b.Name).HasColumnName("name").HasColumnType("nvarchar(20)").IsRequired().HasDefaultValue("");
            builder.Property(b => b.BirthDay).HasColumnName("birthday").HasColumnType("date").IsRequired();
            builder.Property(b => b.Email).HasColumnName("email").HasColumnType("varchar(200)").IsRequired().HasDefaultValue("");
            builder.Property(b => b.Account).HasColumnName("account").IsRequired().HasColumnType("varchar(30)").HasDefaultValue("");
            builder.Property(b => b.Password).HasColumnName("password").IsRequired().HasColumnType("char(64)");
            builder.Property(b => b.Status).HasColumnName("status").HasColumnType("bigint").IsRequired().HasDefaultValue(0);
            builder.Property(b => b.CreateTime).HasColumnName("created_at").IsRequired();
            builder.Property(b => b.UpdateTime).HasColumnName("updated_at");
        }
    }
}
