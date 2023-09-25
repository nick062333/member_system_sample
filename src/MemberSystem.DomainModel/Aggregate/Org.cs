namespace MemberSystem.Domain.Aggregate
{
    public class Org : IAggregateRoot
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("title", TypeName = "nvarchar(50)")]
        [Required]
        public string? Title { get; set; }

        [Column("org_no", TypeName = "varchar(20)")]
        [Required]
        public string? OrgNo { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreateTime { get; set; }

        [Column("updated_at")]
        public DateTime? UpdateTime { get; set; }
    }
}
