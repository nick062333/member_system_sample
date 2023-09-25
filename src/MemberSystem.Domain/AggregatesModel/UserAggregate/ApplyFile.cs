using MemberSystem.Domain.SeedWork;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberSystem.Domain.AggregatesModel.UserAggregate
{
    public class ApplyFile : Entity
    {
        public long Id { get; set; }

        public required long UserId { get; set; }

        public required string FilePath { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
