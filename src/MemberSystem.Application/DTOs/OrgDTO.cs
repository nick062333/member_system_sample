using System.ComponentModel.DataAnnotations.Schema;

namespace MemberSystem.Application.DTOs
{
    public class OrgDTO
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("title")]
        public string? Title { get; set; }

        [Column("org_no")]
        public string? OrgNo { get; set; }
    }
}
