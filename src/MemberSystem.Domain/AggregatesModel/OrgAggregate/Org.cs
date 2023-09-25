using MemberSystem.Domain.SeedWork;

namespace MemberSystem.Domain.AggregatesModel.OrgAggregate
{
    public class Org : IAggregateRoot
    {
        public long Id { get; set; }

        public string? Title { get; set; }

        public string? OrgNo { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
