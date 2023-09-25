using MemberSystem.Domain.AggregatesModel.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MemberSystem.Infrastructure.EntityFrameworkCore.EntityTypeConfiguration
{
    internal class SysLogEntityConfiguration : IEntityTypeConfiguration<SysLog>
    {
        public void Configure(EntityTypeBuilder<SysLog> builder)
        {
            builder.ToTable("syslog");
            builder.HasKey(b => b.SeqNo).HasName("seq_no");
            builder.Property(b => b.Account).HasColumnName("account").HasColumnType("varchar(30)").HasDefaultValue("");
            builder.Property(b => b.IPAddress).HasColumnName("ipaddress").HasColumnType("varchar(15)").HasDefaultValue("");
            builder.Property(b => b.LoginTime).HasColumnName("login_at").IsRequired();
            builder.Property(b => b.CreateTime).HasColumnName("created _at").IsRequired();
        }
    }
}
