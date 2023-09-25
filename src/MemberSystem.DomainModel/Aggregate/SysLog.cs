using MemberSystem.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberSystem.Domain.Aggregate
{
    public class SysLog : IAggregateRoot
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("account")]
        [Required]
        public required string Account { get; set; }

        [Column("ipaddress")]
        [Required]
        public required string IPAddress { get; set; }

        [Column("login_at")]
        [Required]
        public DateTime LoginTime { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreateTime { get; set; }
    }
}
