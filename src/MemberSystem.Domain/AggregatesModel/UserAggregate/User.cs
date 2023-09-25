using MemberSystem.Domain.SeedWork;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberSystem.Domain.AggregatesModel.UserAggregate
{
    public class User : IAggregateRoot
    {
        public long Id { get; private set; }

        public long OrgId { get; private set; }

        public string Name { get; private set; }

        public DateTime BirthDay { get; private set; }

        public string Email { get; private set; }

        public string Account { get; private set; }

        public string Password { get; private set; }

        public int Status { get; private set; }

        public DateTime CreateTime { get; private set; }

        public DateTime? UpdateTime { get; private set; }
    }
}
