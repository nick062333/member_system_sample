using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MemberSystem.Domain.AggregatesModel.UserAggregate;

namespace MemberSystem.Infrastructure.EntityFrameworkCore.EntityTypeConfiguration
{
    public class ApplyFileEntityTypeConfiguration : IEntityTypeConfiguration<ApplyFile>
    {
        public void Configure(EntityTypeBuilder<ApplyFile> builder)
        {
            builder.ToTable("apply_file");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("id");
            builder.Property(b => b.UserId).HasColumnName("user_id");
            builder.Property(b => b.FilePath).HasColumnName("file_path").HasColumnType("varchar(200)").HasDefaultValue("");
            builder.Property(b => b.CreateTime).HasColumnName("created_at").IsRequired();
            builder.Property(b => b.UpdateTime).HasColumnName("updated_at");
        }
    }
}
