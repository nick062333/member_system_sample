using MemberSystem.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberSystem.Domain.Aggregate
{
    public class User : IAggregateRoot
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("org_id")]
        [Required]
        public required long OrgId { get; set; }

        [Column("name", TypeName = "nvarchar(50)")]
        [Required]
        public required string Name { get; set; }

        [Column("birth_day", TypeName = "date")]
        [Required]
        public DateTime BirthDay { get; set; }

        [Column("email", TypeName = "varchar(100)")]
        [Required]
        public required string Email { get; set; }

        [Column("account", TypeName = "varchar(50)")]
        [Required]
        public required string Account { get; set; }

        [Column("password", TypeName = "varchar(MAX)")]
        [Required]
        public required string Password { get; set; }

        [Column ("status")]
        [Required]
        public int Status { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreateTime { get; set; }

        [Column("updated_at")]
        public DateTime? UpdateTime { get; set; }
    }
}
