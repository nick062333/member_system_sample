using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MemberSystem.Domain.AggregatesModel.OrgAggregate;

namespace MemberSystem.Infrastructure.EntityFrameworkCore.EntityTypeConfiguration
{
    public class OrgEntityTypeConfiguration : IEntityTypeConfiguration<Org>
    {
        public void Configure(EntityTypeBuilder<Org> builder)
        {
            builder.ToTable("orgs");
            builder.HasKey(b => b.Id).HasName("id");
            builder.Property(b => b.OrgNo).HasColumnName("org_no").IsRequired().HasColumnType("varchar(20)").HasDefaultValue("");
            builder.Property(b => b.Title).HasColumnName("title").IsRequired().HasColumnType("nvarchar(20)").HasDefaultValue("");
            builder.Property(b => b.CreateTime).HasColumnName("created_at").IsRequired();
            builder.Property(b => b.UpdateTime).HasColumnName("updated_at");
        }
    }
}
