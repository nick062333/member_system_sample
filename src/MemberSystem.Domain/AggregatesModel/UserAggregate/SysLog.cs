using MemberSystem.Domain.SeedWork;
 
namespace MemberSystem.Domain.AggregatesModel.UserAggregate
{
    public class SysLog : Entity
    {
        public long SeqNo { get; set; }

        public required string Account { get; set; }

        public required string IPAddress { get; set; }

        public DateTime LoginTime { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
