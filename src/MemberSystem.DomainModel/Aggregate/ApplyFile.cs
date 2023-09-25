using MemberSystem.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberSystem.Domain.Aggregate
{
    public class ApplyFile: IAggregateRoot
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("user_id")]
        [Required]
        public required long UserId { get; set; }

        [Column("file_path", TypeName = "varchar(200)")]
        [Required]
        public required string FilePath { get ; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreateTime { get; set; }

        [Column("updated_at")]
        public DateTime? UpdateTime { get; set; }
    }
}
